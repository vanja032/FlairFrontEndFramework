using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlairFrameworkCreatePropertiesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PreciseStartCheck(cbPrecize);
        }

        private void cbPrecize_CheckedChanged(object sender, EventArgs e)
        {
            PreciseStartCheck(cbPrecize);
        }
        private void PreciseStartCheck(CheckBox cbPrecize)
        {
            if (cbPrecize.Checked)
            {
                psFrom.Enabled = true;
                psTo.Enabled = true;
                psStep.Enabled = true;
            }
            else
            {
                psFrom.Enabled = false;
                psTo.Enabled = false;
                psStep.Enabled = false;
            }
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(tbFileName.Text+((cbFileType.Checked)?".css":".txt"), false);
            
            for(int i=0;i<lbBlockSize.Items.Count;i++)
            {
                for (int j = 0; j < lbProperty.Items.Count; j++)
                {
                    if (cbPrecize.Checked)
                    {
                        int psStepLength = psStep.Text.ToString().Substring(psStep.Text.ToString().IndexOf('.') + 1).Length;
                        for (decimal k = Math.Round(Convert.ToDecimal(psFrom.Text), psStepLength); k <= Math.Round(Convert.ToDecimal(psTo.Text), psStepLength); k += Math.Round(Convert.ToDecimal(psStep.Text), psStepLength))
                        {
                            string propertyInversion = "";
                            if (lbProperty.Items[j].ToString().Contains("&I"))
                                propertyInversion = "100% - ";
                            if (lbProperty.Items[j].ToString().Contains("&HI"))
                                propertyInversion = "50% - ";

                            string propertyDefinition = "";
                            for (int l = 0; l < lbPropertyDefinition.Items[j].ToString().Split('|').Length; l++)
                                propertyDefinition += lbPropertyDefinition.Items[j].ToString().Split('|')[l] + ":calc(" + propertyInversion + Math.Round(k, psStepLength).ToString() + "*var(" + lbPropertyVariable.Items[i].ToString() + "))" + ((cbImportant.Checked) ? " !important;" : ";");
                            string p = Math.Round(k, psStepLength).ToString();
                            sw.WriteLine(String.Format(".{0}{1}unit{2}{{{3}}}", lbBlockSize.Items[i].ToString(), lbProperty.Items[j].ToString().Replace("&I", "").Replace("&HI", ""), p.Substring(0, (p.IndexOf('.')!=-1)? p.IndexOf('.') : p.Length) +"_"+p.Substring((p.IndexOf('.') != -1) ? p.IndexOf('.')+1 : p.Length - 1).PadRight(psStepLength, '0'), propertyDefinition));
                        }
                    }
                    int mainStepLength = mainStep.Text.ToString().Substring(mainStep.Text.ToString().IndexOf('.') + 1).Length;
                    for (decimal k = Math.Round(Convert.ToDecimal(mainFrom.Text), mainStepLength); k <= Math.Round(Convert.ToDecimal(mainTo.Text), mainStepLength); k += Math.Round(Convert.ToDecimal(mainStep.Text), mainStepLength))
                    {
                        string propertyInversion = "";
                        if (lbProperty.Items[j].ToString().Contains("&I"))
                            propertyInversion = "100% - ";
                        if (lbProperty.Items[j].ToString().Contains("&HI"))
                            propertyInversion = "50% - ";

                        string propertyDefinition = "";
                        for (int l = 0; l < lbPropertyDefinition.Items[j].ToString().Split('|').Length; l++)
                            propertyDefinition += lbPropertyDefinition.Items[j].ToString().Split('|')[l] + ":calc(" + propertyInversion + Math.Round(k, mainStepLength).ToString() + "*var(" + lbPropertyVariable.Items[i].ToString() + "))" + ((cbImportant.Checked) ? " !important;" : ";");
                        string p = Math.Round(k, mainStepLength).ToString();
                        sw.WriteLine(String.Format(".{0}{1}unit{2}{{{3}}}", lbBlockSize.Items[i].ToString(), lbProperty.Items[j].ToString().Replace("&I", "").Replace("&HI", ""), p.Substring(0, (p.IndexOf('.') != -1) ? p.IndexOf('.') : p.Length) + "_" + p.Substring((p.IndexOf('.') != -1) ? p.IndexOf('.') + 1 : p.Length - 1).PadRight(mainStepLength, '0'), propertyDefinition));
                    }
                }
            }
            sw.Close();
        }
    }
}
