using RuleEngineService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Rule = RuleEngineService.Rule;

namespace RuleEngineApp
{
    public partial class Form1 : Form
    {
        private BackgroundWorker _backgroundWorker;
        private List<StreamData> _streamData;
        private List<Rule> _rules;
        private string _ruleFilePath = "StramDataRules.json";
        private readonly StreamRuleService _streamRuleService;

        public Form1()
        {
            InitializeComponent();
            _streamRuleService = new StreamRuleService();

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if (dlgOpenInputFile.ShowDialog() == DialogResult.OK)
            {
                lblFilePath.Text = dlgOpenInputFile.FileName.ToString();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(lblFilePath.Text))
                {
                    MessageBox.Show("Choose valid File", "File Not exist!");
                    return;
                }

                pbStatus.Style = ProgressBarStyle.Marquee;
                pbStatus.MarqueeAnimationSpeed = 50;

                _backgroundWorker = new BackgroundWorker();
                _backgroundWorker.WorkerSupportsCancellation = true;
                _backgroundWorker.DoWork += _backgroundWorker_DoWork_ApplyRule;
                _backgroundWorker.RunWorkerCompleted += _backgroundWorke_RunWorkerCompleted;
                _backgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pbStatus.Style = ProgressBarStyle.Blocks;
                pbStatus.Value = 0;

            }
        }

        private void _backgroundWorker_DoWork_ApplyRule(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!File.Exists(_ruleFilePath))
                    return;

                var streamData = _streamRuleService.GetAllStreamData(lblFilePath.Text);
                var ruleData = _streamRuleService.GetAllRules(_ruleFilePath);

                _streamData = _streamRuleService.ApplyRules(streamData, ruleData).ToList();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }

        }

        private void _backgroundWorke_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                pbStatus.Style = ProgressBarStyle.Blocks;
                pbStatus.Value = 0;
                dgRuleResult.DataSource = _streamData;
                lblCount.Text = _streamData?.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbSignalID.Text) && cmbValueTypes.SelectedIndex == -1 &&
                    cmbRuleRelation.SelectedIndex == -1)
                    throw new Exception("Please Enter Values");

                if (cmbValueTypes.SelectedIndex == 1 && !int.TryParse(tbValue.Text, out var result))
                    throw new Exception("Enetr Valid Type for Interger");


                foreach (var item in lstRuleList.Items)
                {
                    var rule = (Rule)item;
                    if (rule.SignalID == tbSignalID.Text && rule.ValueTYpe == cmbValueTypes.SelectedItem.ToString())
                        throw new Exception("Rule Already Added");
                }

                lstRuleList.ForeColor = Color.Orange;
                var i = lstRuleList.Items.Add(new Rule()
                {
                    SignalID = tbSignalID.Text,
                    ValueTYpe = cmbValueTypes.SelectedItem.ToString(),
                    RuleRelation = cmbRuleRelation.SelectedItem.ToString(),
                    value = cmbValueTypes.SelectedIndex == 2 ? dateTimePicker1.Value.ToString() : tbValue.Text
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbValueTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRuleRelation.Items.Clear();

            if (cmbValueTypes.SelectedIndex == 2)
            {
                tbValue.Visible = false;
                dateTimePicker1.Visible = true;
            }
            else
            {
                tbValue.Visible = true;
                dateTimePicker1.Visible = false;
            }
            cmbRuleRelation.Items.Add(Constants.IsEqualTo);
            cmbRuleRelation.Items.Add(Constants.IsNotEqualTo);
            switch (cmbValueTypes.SelectedIndex)
            {
                case 0:
                    cmbRuleRelation.Items.Add(Constants.Contains);
                    break;
                default:
                    cmbRuleRelation.Items.Add(Constants.IsGreaterThan);
                    cmbRuleRelation.Items.Add(Constants.IsLessThan);
                    break;
            }
            cmbRuleRelation.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbValueTypes.Items.Add(Constants.String);
            cmbValueTypes.Items.Add(Constants.Integer);
            cmbValueTypes.Items.Add(Constants.Datetime);
            LoadRules();

        }

        /// <summary>
        /// Gets all the Rules and loads it into list view
        /// </summary>
        private void LoadRules()
        {
            try
            {
                var rules = _streamRuleService.GetAllRules(_ruleFilePath);
                lstRuleList.Items.Clear();
                lstRuleList.ForeColor = Color.Green;

                foreach (var rule in rules)
                {
                    lstRuleList.Items.Add(rule);
                }
                //rules.Select(item => lstRuleList.Items.Add(item));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetRule_Click(object sender, EventArgs e)
        {
            try
            {
                List<Rule> ruleList = new List<Rule>();

                foreach (var item in lstRuleList.Items)
                {
                    ruleList.Add((Rule)item);
                }

                _streamRuleService.SetRules(ruleList, _ruleFilePath);

                LoadRules();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetAllData_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(lblFilePath.Text))
                {
                    MessageBox.Show("Choose valid File", "File Not exist!");
                    return;
                }

                pbStatus.Style = ProgressBarStyle.Marquee;
                pbStatus.MarqueeAnimationSpeed = 50;

                _backgroundWorker = new BackgroundWorker();
                _backgroundWorker.WorkerSupportsCancellation = true;
                _backgroundWorker.DoWork += _backgroundWorker_DoWork_GetAllStreamData;
                _backgroundWorker.RunWorkerCompleted += _backgroundWorke_RunWorkerCompleted;
                _backgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pbStatus.Style = ProgressBarStyle.Blocks;
                pbStatus.Value = 0;

            }
        }

        private void _backgroundWorker_DoWork_GetAllStreamData(object sender, DoWorkEventArgs e)
        {
            try
            {
                _streamData = _streamRuleService.GetAllStreamData(lblFilePath.Text);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btnremoveRule_Click(object sender, EventArgs e)
        {
            if (lstRuleList.SelectedIndex != -1)
            {
                lstRuleList.Items.RemoveAt(lstRuleList.SelectedIndex);
                lstRuleList.ForeColor = Color.Orange;
            }

            else
                MessageBox.Show("Please Select Rule to remove");

        }

        /// <summary>
        /// Shows Message PopUP from UI thread.
        /// </summary>
        /// <param name="message"></param>
        private void ShowMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(ShowMessage), message);
                return;
            }
            MessageBox.Show(message);
        }
    }
}
