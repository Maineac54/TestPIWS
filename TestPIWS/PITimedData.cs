using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.ServiceModel.Description;
using System.Text.RegularExpressions;

namespace TestPIWS
{

	class PITimedData : IPITimeSeries
	{

		// Class Data
		private String mstrPISrvNm;
		private List<String> mlstTags;
		private string mstrQltyMask;
		private DateTime mdtStart;
		private DateTime mdtEnd;
		private int mintValCnt;
		private int mintInterval;		// in seconds
		private StringBuilder output;
		private StringWriter debOut;
		private bool Debugging = false;
		private bool IsConnected = false;

		private PITimeSeriesClient client = null;

		// Class Constructors
		public PITimedData(StringWriter DebugOutput)
		{
			// set debug output stream first
			SetDebugStream(DebugOutput);

			// create the list of tags
			mlstTags = new List<string>();

			// set default start and end times
			mdtStart = DateTime.Now;
			mdtEnd = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));

			// setup for debug output
			output = new StringBuilder();

			Connect();
			WriteOutput();
			// Clear the output
			output = new StringBuilder();
		}

		#region Class Properties

		public String PISrvNm
		{
			get { return mstrPISrvNm; }
			set 
			{ 
				mstrPISrvNm = value;
			}
		}
		public DateTime Start
		{
			get { return mdtStart; }
			set { mdtStart = value; }
		}
		public DateTime End
		{
			get { return mdtEnd; }
			set { mdtEnd = value; }
		}
		public List<String> Tags
		{
			get { return mlstTags; }
			set { mlstTags = value; }
		}
		public string QualityMask {
			get
			{
				return (mstrQltyMask);
			}
			set
			{
				mstrQltyMask = value;
			}
		}
		public int ValCount
		{
			get { return mintValCnt; }
			set { mintValCnt = value; }
		}
		public int Interval
		{
			get { return mintInterval; }
			set { mintInterval = value; }
		}
		public bool Connected
		{
			get { return IsConnected; }
		}

		#endregion

		#region Class Methods

		public void SetDebugStream(StringWriter DebugOut) {
			try
			{
				debOut = DebugOut;
				Debugging = true;
			}
			catch (Exception)
			{
				Debugging = false;
			}
		}
		private void WriteOutput()
		{
			if (Debugging)
			{
				debOut.Write(output.ToString());
			}
		}

		public bool Connect()
		{
			try
			{
				if(client == null)
					client = new PITimeSeriesClient();
				
				client.Open();
				output.AppendLine(client.State.ToString());
				output.AppendLine(client.InnerChannel.RemoteAddress.Uri.PathAndQuery);

				WriteCredentials();

				IsConnected = true;
			}
			catch (Exception ex)
			{
				IsConnected = false;

				output.AppendLine(ex.Message);
				if (ex.InnerException != null)
				{
					output.AppendLine(ex.InnerException.Message);
				}
			}

			return (IsConnected);
		}
		private void WriteCredentials()
		{
			ClientCredentials clientCred = client.ClientCredentials;

			if (clientCred.ClientCertificate.Certificate != null)
			{
				output.AppendLine("Certificate FN=" +
					clientCred.ClientCertificate.Certificate.FriendlyName);
				output.AppendLine("Certificate SerNo=" +
					clientCred.ClientCertificate.Certificate.SerialNumber);
			}
			else if (clientCred.HttpDigest.ClientCredential.UserName != "")
			{
				output.AppendLine("Digest UserName: " +
					clientCred.HttpDigest.ClientCredential.UserName);
			}
			else
				output.AppendLine("No Authentication required or provided.");

			//WriteOutput();
		}
		private string[] GetTags()
		{
			String[] tags = null;

			try
			{
				tags = new String[Tags.Count * 2];

				for (int i = 0; i < Tags.Count; i++)
				{
					tags[i * 2] = String.Format("pi:\\\\{0}\\{1}", mstrPISrvNm, Tags[i]);
					if (mstrQltyMask != "")
					{
						Regex rex = new Regex("\\*");
						string dqTag = rex.Replace(mstrQltyMask, Tags[i]);
						tags[(i * 2) + 1] = String.Format("pi:\\\\{0}\\{1}", mstrPISrvNm, dqTag);
					}
					else
					{
						tags[(i * 2) + 1] = "";
					}
					output.AppendLine(tags[i * 2]);
				}
			}
			catch (Exception ex)
			{
				output.AppendLine(ex.Message);
				if (ex.InnerException != null)
				{
					output.AppendLine(ex.InnerException.Message);
				}
				WriteOutput();
			}

			return (tags);
		}
		private TimeSeries[] CheckResult(TimeSeries[] ts)
		{
			try
			{
				foreach (TimeSeries tim in ts)
				{
					if (tim.Error != 0)
					{
						output.AppendLine(tim.ErrDesc);
					}
				}
			}
			catch (Exception ex)
			{
				output.AppendLine(ex.Message);
				ts = null;
			}

			//WriteOutput();
			return (ts);
		}
		private void CheckDates()
		{
			if (mdtEnd < mdtStart)
			{
				DateTime temp = mdtEnd;
				mdtEnd = mdtStart;
				mdtStart = temp;

				output.AppendLine("Dates out-of-order.  Switching Start and End.");
			}
		}

		public TimeSeries[] GetSnapshot()
		{
			// This function will get the current value of every tag requested
			try
			{
				String[] tags = GetTags();
				
				TimeSeries[] ts = client.GetPISnapshotData(tags);

				// Always close the client.
				client.Close();

				WriteOutput();
				return (CheckResult(ts));
			}
			catch (Exception ex)
			{
				output.AppendLine(ex.Message);
				if (ex.InnerException != null)
				{
					output.AppendLine(ex.InnerException.Message);
				}
				WriteOutput();
				return null;
			}
		}
		public TimeSeries[] GetArchiveData()
		{
			// This function gets compressed archive data for a list of tags
			// from the same PI server over the same time range.
			try
			{
				if (mintValCnt == 0)
					mintValCnt = Int32.MaxValue;
				String[] tags = GetTags();

				PIArcDataRequest[] padReqs = new PIArcDataRequest[tags.Length];

				// Adjust start and end times to account for time zone
				CheckDates();  // insure that start is before end
				TimeRange tr = new TimeRange();
				tr.Start = mdtStart.ToString("yyyy-MM-ddTHH:mm:ss-08:00");
				tr.End = mdtEnd.ToString("yyyy-MM-ddTHH:mm:ss-08:00");

				PIArcManner paManr = new PIArcManner();
				paManr.RetrievalType = PIArcMannerRetrievalType.Compressed;
				paManr.Boundaries = PIArcMannerBoundaries.Inside;
				paManr.NumValues = mintValCnt;

				for (int i = 0; i < tags.Length; i++)
				{
					PIArcDataRequest padReq = new PIArcDataRequest();
					padReq.Path = tags[i];
					padReq.PIArcManner = paManr;
					padReq.TimeRange = tr;

					padReqs[i] = padReq;
				}

				TimeSeries[] ts = client.GetPIArchiveData(padReqs);

				// Always close the client.
				client.Close();

				WriteOutput();
				return (CheckResult(ts));
			}
			catch (Exception ex)
			{
				output.AppendLine(ex.Message);
				if (ex.InnerException != null)
				{
					output.AppendLine(ex.InnerException.Message);
				}
				WriteOutput();
				return null;
			}
		}
		public TimeSeries[] GetSampleData()
		{
			// This function gets sampled values for a list of tags
			// from the same PI server over the same time range at the 
			// interval specified.
			try
			{
				if (mintValCnt == 0)
					mintValCnt = Int32.MaxValue;
				String[] tags = GetTags();

				PIArcDataRequest[] padReqs = new PIArcDataRequest[tags.Length];

				// Adjust start and end times to account for time zone
				CheckDates();  // insure that start is before end
				TimeRange tr = new TimeRange();
				tr.Start = mdtStart.ToString("yyyy-MM-ddTHH:mm:ss-08:00");
				tr.End = mdtEnd.ToString("yyyy-MM-ddTHH:mm:ss-08:00");

				PIArcManner paManr = new PIArcManner();
				paManr.RetrievalType = PIArcMannerRetrievalType.Interpolated;
				paManr.Boundaries = PIArcMannerBoundaries.Interpolated;
				// Calculate the number of intervals based on the interval and time span
				TimeSpan span = mdtEnd.Subtract(mdtStart);
				mintValCnt = (int)(span.TotalSeconds / Convert.ToDouble(mintInterval)) + 1;
				paManr.NumValues = mintValCnt;

				for (int i = 0; i < tags.Length; i++)
				{
					PIArcDataRequest padReq = new PIArcDataRequest();
					padReq.Path = tags[i];
					padReq.PIArcManner = paManr;
					padReq.TimeRange = tr;

					padReqs[i] = padReq;
				}

				TimeSeries[] ts = client.GetPIArchiveData(padReqs);

				// Always close the client.
				client.Close();

				WriteOutput();
				return (CheckResult(ts));
			}
			catch (Exception ex)
			{
				output.AppendLine(ex.Message);
				if (ex.InnerException != null)
				{
					output.AppendLine(ex.InnerException.Message);
				}
				WriteOutput();
				return null;
			}
		}
		public string GetProductVersion()
		{
			string ret;

			try
			{
				ret = client.GetProductVersion();
			}
			catch (Exception )
			{
				ret = "Unknown";
			}

			return ret;
		}

		public TimeSeries WriteToPI(string PITag, DateTime time, string Value )
		{
			// This function will the value provide to the named tag at the time provided
			TimeSeries ts = null;

			try
			{
				string path = String.Format("pi:\\\\{0}\\{1}", mstrPISrvNm, PITag);
				TimedValue val = new TimedValue();

				val.Path = path;
				val.Time = time;
				val.Value = Value;

				TimeSeries[] events = new TimeSeries[1];
				events[0] = new TimeSeries();
				events[0].TimedValues = new TimedValue[1];
				events[0].TimedValues.SetValue(val, 0);

				ts = client.InsertPIData(events,
					InsertPIDataDuplicateSwitch.ReplaceDuplicate);

				// Always close the client.
				client.Close();

				WriteOutput();
			}
			catch (Exception ex)
			{
				output.AppendLine(ex.Message);
				WriteOutput();
			}

			return ts;
		}

		#endregion

		#region IPITimeSeries Members

		public TimeSeries[] GetPIArchiveData(PIArcDataRequest[] requests)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task<TimeSeries[]> GetPIArchiveDataAsync(PIArcDataRequest[] requests)
		{
			throw new NotImplementedException();
		}

		public TimeSeriesUpdates[] GetPIUpdates(Guid updateTicket, ushort maxWaitForUpdates, UpdateFilterType evtFilter)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task<TimeSeriesUpdates[]> GetPIUpdatesAsync(Guid updateTicket, ushort maxWaitForUpdates, UpdateFilterType evtFilter)
		{
			throw new NotImplementedException();
		}

		public SignUpResults SignUpForPIUpdates(string[] paths, ushort expiration)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task<SignUpResults> SignUpForPIUpdatesAsync(string[] paths, ushort expiration)
		{
			throw new NotImplementedException();
		}

		public void CancelSignUpForPIUpdates(Guid updateTicket)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task CancelSignUpForPIUpdatesAsync(Guid updateTicket)
		{
			throw new NotImplementedException();
		}

		public string[] ListPathsByUpdateTicket(Guid updateTicket)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task<string[]> ListPathsByUpdateTicketAsync(Guid updateTicket)
		{
			throw new NotImplementedException();
		}

		public TimeSeries[] GetPISnapshotData(string[] paths)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task<TimeSeries[]> GetPISnapshotDataAsync(string[] paths)
		{
			throw new NotImplementedException();
		}

		public TimeSeries[] GetPISummaryData(PISummaryDataRequest[] requests)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task<TimeSeries[]> GetPISummaryDataAsync(PISummaryDataRequest[] requests)
		{
			throw new NotImplementedException();
		}

		public TimeSeries InsertPIData(TimeSeries[] events, InsertPIDataDuplicateSwitch duplicateSwitch)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task<TimeSeries> InsertPIDataAsync(TimeSeries[] events, InsertPIDataDuplicateSwitch duplicateSwitch)
		{
			throw new NotImplementedException();
		}

		public System.Threading.Tasks.Task<string> GetProductVersionAsync()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
