using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.ServiceModel.Description;
//using MessageInspector;

namespace TestPIWS
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();

			// Set Comp Data times
			this.picTo.Value = DateTime.Now;
			this.picFrom.Value = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));

			// Set Sample Data times
			this.picSmplFrom.Value = DateTime.Now.Subtract(new TimeSpan(4, 0, 0));
			this.picSmplTo.Value = DateTime.Now;

			// Set Write Tab time
			this.picWrite.Value = DateTime.Now;
		}

		#region Form Methods

		private string SnapShot() 
		{
			string retVal = "Failed";

			StringWriter sw = new StringWriter();

			PITimedData piDat = new PITimedData(sw);

			if (piDat.Connected)
			{
				piDat.PISrvNm = this.txtPISrvrNm.Text;
				piDat.QualityMask = txtQltyMask.Text;
				piDat.Tags.Add(txtSnapShotTag.Text);
				
				TimeSeries[] ts = piDat.GetSnapshot();
				if (ts == null)
				{
					this.txtCompOut.Text = sw.ToString() + "::Unable to return values from PI Web Services.";

					return("Nothing to return.");
				}
				if (ts == null)
				{
					retVal = "GetSnapshot Failed.";
				}
				else
				{
					if (ts.Length > 0)
					{
						if (ts[0].TimedValues.Length > 0)
						{
							TimedValue tv = ts[0].TimedValues[0];
							if (ts[1].TimedValues.Length > 0)
							{
								TimedValue tvq = ts[1].TimedValues[0];
								retVal = String.Format("{0:dd-MMM-yy HH:mm:ss} - {1} [{2}]", tv.Time.ToLocalTime(),
														tv.Value, tvq.Value);
							} else
								retVal = String.Format("{0:dd-MMM-yy HH:mm:ss} - {1} [{2}]", tv.Time.ToLocalTime(),
														tv.Value, "");
						}
						else
						{
							retVal = "Unable to get Values.";
						}
					}
					else
					{
						retVal = "Unable to find tag.";
					}
				}
			}

			txtSnapShotOut.Text = sw.ToString();
			return (retVal);
		}
		private void GetCompData()
		{
			StringWriter sw = new StringWriter();

			PITimedData piDat = new PITimedData(sw);
			if (piDat.Connected)
			{
				piDat.PISrvNm = this.txtPISrvrNm.Text;
				piDat.QualityMask = this.txtQltyMask.Text;
				//piDat.SetDebugStream(sw);
				piDat.Tags.Add(this.txtCompTag.Text);
				piDat.Start = picFrom.Value;
				piDat.End = picTo.Value;
				piDat.ValCount = int.Parse(this.txtValCnt.Text);

				TimeSeries[] ts = piDat.GetArchiveData();
				if (ts == null)
				{
					this.txtCompOut.Text = sw.ToString() + "::Unable to return values from PI Web Services.";

					return;
				}

				if (ts[0].Error == 0)
				{
					DataTable dt = new DataTable("PIdata");
					dt.Columns.Add("Time");
					dt.Columns.Add("Value");
					dt.Columns.Add("Status");
					dt.Columns.Add("Quality");

					TimedValue[] tvq = null;
					if(ts[1].TimedValues.Length > 0)
					  tvq = ts[1].TimedValues;

					int iq = 0;

					foreach (TimedValue tv in ts[0].TimedValues)
					{
						DataRow dr = dt.NewRow();

						dr["Time"] = tv.Time.ToLocalTime().ToString();
						dr["Value"] = tv.Value;
						dr["Status"] = tv.Status;

						if (tvq != null)
						{
							// find data quality for value time
							while (tvq[iq].Time <= tv.Time)
							{
								iq++;
								if (iq >= tvq.Length)
									break;
							}
							iq--;

							dr["Quality"] = tvq[iq].Value;
						}

						dt.Rows.Add(dr);
					}

					dgvCompData.DataSource = dt;
					dgvCompData.AutoResizeColumns();
				}
				else
				{
					dgvCompData.DataSource = null;
				}
			}

			this.txtCompOut.Text = sw.ToString();
		}
		private void GetSmplData()
		{
			StringWriter sw = new StringWriter();

			PITimedData piDat = new PITimedData(sw);
			if (piDat.Connected)
			{
				piDat.PISrvNm = this.txtPISrvrNm.Text;
				piDat.QualityMask = this.txtQltyMask.Text;
				piDat.Tags.Add(this.txtSmplTag.Text);
				piDat.Start = this.picSmplFrom.Value;
				piDat.End = this.picSmplTo.Value;

				// Conver interval to seconds
				int val = int.Parse(this.txtSmplIntv.Text);
				if (cboSmplUnit.Text == "s")
				{
					// No change
				}
				else if (cboSmplUnit.Text == "m")
				{
					val = val * 60;
				}
				else if (cboSmplUnit.Text == "h")
				{
					val = val * 3600;
				}
				else if (cboSmplUnit.Text == "d")
				{
					val = val * 86400; 
				}
				piDat.Interval = val;

				TimeSeries[] ts = piDat.GetSampleData();
				if (ts == null)
				{
					this.txtCompOut.Text = sw.ToString() + "::Unable to return values from PI Web Services.";

					return;
				}
				if (ts[0].Error == 0)
				{
					TimeSeries tv = ts[0];
					TimeSeries tq = ts[1];

					DataTable dt = new DataTable("PIdata");
					dt.Columns.Add("Time");
					dt.Columns.Add("Value");
					dt.Columns.Add("Status");
					dt.Columns.Add("Quality");

					for (int i = 0; i < tv.TimedValues.Length; i++)
					{
						TimedValue tvv = tv.TimedValues[i];

						DataRow dr = dt.NewRow();

						dr["Time"] = tvv.Time.ToLocalTime().ToString();
						dr["Value"] = tvv.Value;
						dr["Status"] = tvv.Status;

						if (tq.TimedValues.Length > 0)
						{
							TimedValue tqv = tq.TimedValues[i];
							dr["Quality"] = tqv.Value;
						}

						dt.Rows.Add(dr);
					}

					dgvSmplData.DataSource = dt;
					dgvSmplData.AutoResizeColumns();
				}
				else
				{
					dgvSmplData.DataSource = null;
				}
			}

			this.txtSmplOut.Text = sw.ToString();
		}
		private void WriteData()
		{
			StringBuilder output = new StringBuilder("Failed");
			StringWriter sw = new StringWriter();

			PITimedData piDat = new PITimedData(sw);
			if (piDat.Connected)
			{
				piDat.PISrvNm = this.txtPISrvrNm.Text;
				piDat.QualityMask = this.txtQltyMask.Text;
				//piDat.SetDebugStream(sw);

				TimeSeries ts = piDat.WriteToPI(txtWriteTag.Text, picWrite.Value, txtWriteVal.Text);
				if (ts == null)
				{
					output = new StringBuilder(sw.ToString());
					output.AppendLine("Insert PI Data Failed.");
				}
				else
				{
					output = new StringBuilder(sw.ToString());

					if (ts.TimedValues.Length > 0)
					{
						output.AppendLine("The following values did not write:");
						foreach (TimedValue tv in ts.TimedValues)
						{
							output.AppendLine(String.Format("{0:dd-MMM-yy HH:mm:ss} - {1}", tv.Time.ToLocalTime(),
													tv.Value));
						}
					}
					else
					{
						output.AppendLine("All values written.");
					}
				}
			}

			txtWriteOut.Text = output.ToString();
		}

		#endregion

		#region Form Event Handlers

		private void button1_Click(object sender, EventArgs e)
		{
			this.txtSnapShotValue.Text = SnapShot();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();

		}
		private void button3_Click(object sender, EventArgs e)
		{
			GetCompData();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			GetSmplData();
		}
		private void btnWriteData_Click(object sender, EventArgs e)
		{
			WriteData();
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (this.Height < 530) this.Height = 530;
			if (this.Width < 550) this.Width = 550;

			tabControl1.Height = this.Height - 118;
			tabControl1.Width = this.Width - 36;

			button2.Top = this.Height - 68;
			button2.Left = this.Width - 116;
		}
		private void tabControl1_Resize(object sender, EventArgs e)
		{
			// Tab 1 controls
			txtSnapShotOut.Height = tabControl1.Height - 122;
			txtSnapShotOut.Width = tabControl1.Width - 20;

			// Tab 2 controls
			int availHgt = tabControl1.Height - 100;
			dgvCompData.Height = Convert.ToInt32(availHgt * 0.67);
			dgvCompData.Width = tabControl1.Width - 20;

			txtCompOut.Width = tabControl1.Width - 20;
			txtCompOut.Height = Convert.ToInt32(availHgt * 0.33);
			txtCompOut.Top = tabControl1.Height - (txtCompOut.Height + 30);

			// Tab 3 controls
			availHgt = tabControl1.Height - 100;
			dgvSmplData.Height = Convert.ToInt32(availHgt * 0.67);
			dgvSmplData.Width = tabControl1.Width - 20;

			txtSmplOut.Width = tabControl1.Width - 20;
			txtSmplOut.Height = Convert.ToInt32(availHgt * 0.33);
			txtSmplOut.Top = tabControl1.Height - (txtCompOut.Height + 30);

		}

		#endregion
	}
}
