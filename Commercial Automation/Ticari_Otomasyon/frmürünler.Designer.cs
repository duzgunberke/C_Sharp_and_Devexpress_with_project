
namespace Ticari_Otomasyon
{
    partial class frmürünler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmürünler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btngüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchdetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtsatış = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.nmradet = new System.Windows.Forms.NumericUpDown();
            this.txtalış = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtmodel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtmarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.mskyıl = new System.Windows.Forms.MaskedTextBox();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatış.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmradet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalış.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmodel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1759, 770);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(200)))), ((int)(((byte)(154)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btngüncelle);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.rchdetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtsatış);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.nmradet);
            this.groupControl1.Controls.Add(this.txtalış);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtmodel);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtmarka);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.mskyıl);
            this.groupControl1.Controls.Add(this.txtad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1755, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(291, 770);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // btngüncelle
            // 
            this.btngüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Appearance.Options.UseFont = true;
            this.btngüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngüncelle.ImageOptions.Image")));
            this.btngüncelle.Location = new System.Drawing.Point(16, 693);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(267, 42);
            this.btngüncelle.TabIndex = 11;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(157, 647);
            this.btnsil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(126, 42);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "SİL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(16, 647);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(126, 42);
            this.btnkaydet.TabIndex = 9;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // rchdetay
            // 
            this.rchdetay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchdetay.Location = new System.Drawing.Point(99, 475);
            this.rchdetay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rchdetay.Name = "rchdetay";
            this.rchdetay.Size = new System.Drawing.Size(177, 148);
            this.rchdetay.TabIndex = 8;
            this.rchdetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(31, 323);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(62, 24);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "ADET :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(19, 475);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 24);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "DETAY :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(27, 419);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 24);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "SATIŞ :";
            // 
            // txtsatış
            // 
            this.txtsatış.Location = new System.Drawing.Point(108, 416);
            this.txtsatış.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsatış.Name = "txtsatış";
            this.txtsatış.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsatış.Properties.Appearance.Options.UseFont = true;
            this.txtsatış.Size = new System.Drawing.Size(159, 30);
            this.txtsatış.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(34, 374);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 24);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "ALIŞ  :";
            // 
            // nmradet
            // 
            this.nmradet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmradet.Location = new System.Drawing.Point(108, 319);
            this.nmradet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmradet.Name = "nmradet";
            this.nmradet.Size = new System.Drawing.Size(157, 32);
            this.nmradet.TabIndex = 5;
            // 
            // txtalış
            // 
            this.txtalış.Location = new System.Drawing.Point(108, 371);
            this.txtalış.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtalış.Name = "txtalış";
            this.txtalış.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtalış.Properties.Appearance.Options.UseFont = true;
            this.txtalış.Size = new System.Drawing.Size(159, 30);
            this.txtalış.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(51, 273);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 24);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "YIL :";
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(108, 223);
            this.txtmodel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmodel.Properties.Appearance.Options.UseFont = true;
            this.txtmodel.Size = new System.Drawing.Size(157, 30);
            this.txtmodel.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 227);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 24);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "MODEL :";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(108, 172);
            this.txtmarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmarka.Properties.Appearance.Options.UseFont = true;
            this.txtmarka.Size = new System.Drawing.Size(157, 30);
            this.txtmarka.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 173);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 24);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "MARKA :";
            // 
            // mskyıl
            // 
            this.mskyıl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskyıl.Location = new System.Drawing.Point(108, 269);
            this.mskyıl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskyıl.Mask = "0000";
            this.mskyıl.Name = "mskyıl";
            this.mskyıl.Size = new System.Drawing.Size(157, 32);
            this.mskyıl.TabIndex = 4;
            this.mskyıl.ValidatingType = typeof(int);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(108, 123);
            this.txtad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtad.Name = "txtad";
            this.txtad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Properties.Appearance.Options.UseFont = true;
            this.txtad.Size = new System.Drawing.Size(157, 30);
            this.txtad.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(54, 127);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "AD :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(108, 74);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Properties.Appearance.Options.UseFont = true;
            this.txtid.Size = new System.Drawing.Size(157, 30);
            this.txtid.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(59, 77);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // frmürünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 768);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmürünler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.frmürünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatış.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmradet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalış.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmodel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private System.Windows.Forms.RichTextBox rchdetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtsatış;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.NumericUpDown nmradet;
        private DevExpress.XtraEditors.TextEdit txtalış;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtmodel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtmarka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.MaskedTextBox mskyıl;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btngüncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
    }
}