
namespace Ticari_Otomasyon
{
    partial class frmnotlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnotlar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.btngüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchdetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtbaşlık = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtoluşturan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txthitap = new DevExpress.XtraEditors.TextEdit();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaşlık.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtoluşturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthitap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(179)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gridControl1.Location = new System.Drawing.Point(-2, -3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1703, 774);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // msktarih
            // 
            this.msktarih.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktarih.Location = new System.Drawing.Point(135, 91);
            this.msktarih.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(196, 29);
            this.msktarih.TabIndex = 31;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Appearance.Options.UseFont = true;
            this.btngüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngüncelle.ImageOptions.Image")));
            this.btngüncelle.Location = new System.Drawing.Point(30, 680);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(145, 50);
            this.btngüncelle.TabIndex = 11;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(185, 626);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(143, 50);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "SİL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(30, 626);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(145, 50);
            this.btnkaydet.TabIndex = 9;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // rchdetay
            // 
            this.rchdetay.Location = new System.Drawing.Point(124, 336);
            this.rchdetay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rchdetay.Name = "rchdetay";
            this.rchdetay.Size = new System.Drawing.Size(205, 264);
            this.rchdetay.TabIndex = 8;
            this.rchdetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(54, 292);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 22);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "HİTAP :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(52, 334);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 22);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "DETAY :";
            // 
            // txtbaşlık
            // 
            this.txtbaşlık.Location = new System.Drawing.Point(132, 188);
            this.txtbaşlık.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtbaşlık.Name = "txtbaşlık";
            this.txtbaşlık.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbaşlık.Properties.Appearance.Options.UseFont = true;
            this.txtbaşlık.Size = new System.Drawing.Size(196, 28);
            this.txtbaşlık.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(4, 244);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(113, 22);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "OLUŞTURAN :";
            // 
            // txtoluşturan
            // 
            this.txtoluşturan.Location = new System.Drawing.Point(132, 238);
            this.txtoluşturan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtoluşturan.Name = "txtoluşturan";
            this.txtoluşturan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtoluşturan.Properties.Appearance.Options.UseFont = true;
            this.txtoluşturan.Size = new System.Drawing.Size(196, 28);
            this.txtoluşturan.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(46, 194);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 22);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "BAŞLIK :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(63, 147);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 22);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "SAAT :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(54, 98);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "TARİH :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(135, 43);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtid.Name = "txtid";
            this.txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Properties.Appearance.Options.UseFont = true;
            this.txtid.Size = new System.Drawing.Size(196, 28);
            this.txtid.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(87, 49);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.txthitap);
            this.groupControl1.Controls.Add(this.msksaat);
            this.groupControl1.Controls.Add(this.msktarih);
            this.groupControl1.Controls.Add(this.btngüncelle);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.rchdetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtbaşlık);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtoluşturan);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1700, -3);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(354, 774);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "NOT OLUŞTURMA PANELİ";
            // 
            // btntemizle
            // 
            this.btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Appearance.Options.UseFont = true;
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(185, 683);
            this.btntemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(143, 47);
            this.btntemizle.TabIndex = 48;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // txthitap
            // 
            this.txthitap.Location = new System.Drawing.Point(132, 286);
            this.txthitap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txthitap.Name = "txthitap";
            this.txthitap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthitap.Properties.Appearance.Options.UseFont = true;
            this.txthitap.Size = new System.Drawing.Size(196, 28);
            this.txthitap.TabIndex = 37;
            // 
            // msksaat
            // 
            this.msksaat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msksaat.Location = new System.Drawing.Point(133, 140);
            this.msksaat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(198, 29);
            this.msksaat.TabIndex = 36;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // frmnotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 768);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmnotlar";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.frmnotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaşlık.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtoluşturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthitap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private DevExpress.XtraEditors.SimpleButton btngüncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private System.Windows.Forms.RichTextBox rchdetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtbaşlık;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtoluşturan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txthitap;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
    }
}