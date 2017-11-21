﻿namespace WordAddInTicTacToe
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupTicTacToe = this.Factory.CreateRibbonGroup();
            this.btCreateTicTacToe = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.groupTicTacToe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.groupTicTacToe);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // groupTicTacToe
            // 
            this.groupTicTacToe.Items.Add(this.btCreateTicTacToe);
            this.groupTicTacToe.Label = "TicTacToe";
            this.groupTicTacToe.Name = "groupTicTacToe";
            // 
            // btCreateTicTacToe
            // 
            this.btCreateTicTacToe.Image = global::WordAddInTicTacToe.Properties.Resources.Tic_tac_toe_logo;
            this.btCreateTicTacToe.Label = "TicTacToe";
            this.btCreateTicTacToe.Name = "btCreateTicTacToe";
            this.btCreateTicTacToe.ShowImage = true;
            this.btCreateTicTacToe.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btCreateTicTacToe_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupTicTacToe.ResumeLayout(false);
            this.groupTicTacToe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupTicTacToe;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btCreateTicTacToe;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
