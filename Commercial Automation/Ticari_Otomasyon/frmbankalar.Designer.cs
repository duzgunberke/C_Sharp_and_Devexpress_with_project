
namespace Ticari_Otomasyon
{
    partial class frmbankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbankalar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmbilçe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mskıban = new System.Windows.Forms.MaskedTextBox();
            this.msktel1 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btngüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtyetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtşube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txthesaptürü = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilçe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtşube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthesaptürü.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(146)))), ((int)(((byte)(172)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(209)))), ((int)(((byte)(205)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gridControl1.Location = new System.Drawing.Point(-3, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1710, 774);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(18, 394);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(113, 22);
            this.labelControl11.TabIndex = 35;
            this.labelControl11.Text = "YETKİLİ ADI :";
            // 
            // cmbilçe
            // 
            this.cmbilçe.Location = new System.Drawing.Point(143, 198);
            this.cmbilçe.Margin = new System.Windows.Forms.Padding(4);
            this.cmbilçe.Name = "cmbilçe";
            this.cmbilçe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbilçe.Properties.Appearance.Options.UseFont = true;
            this.cmbilçe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilçe.Size = new System.Drawing.Size(196, 28);
            this.cmbilçe.TabIndex = 34;
            // 
            // cmbil
            // 
            this.cmbil.Location = new System.Drawing.Point(143, 149);
            this.cmbil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbil.Properties.Appearance.Options.UseFont = true;
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(196, 28);
            this.cmbil.TabIndex = 33;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // mskıban
            // 
            this.mskıban.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskıban.Location = new System.Drawing.Point(143, 291);
            this.mskıban.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mskıban.Name = "mskıban";
            this.mskıban.Size = new System.Drawing.Size(196, 29);
            this.mskıban.TabIndex = 32;
            // 
            // msktel1
            // 
            this.msktel1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktel1.Location = new System.Drawing.Point(143, 441);
            this.msktel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.msktel1.Mask = "(999) 000-0000";
            this.msktel1.Name = "msktel1";
            this.msktel1.Size = new System.Drawing.Size(196, 29);
            this.msktel1.TabIndex = 31;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(82, 201);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 22);
            this.labelControl10.TabIndex = 30;
            this.labelControl10.Text = "İLÇE :";
            // 
            // btngüncelle
            // 
            this.btngüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Appearance.Options.UseFont = true;
            this.btngüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngüncelle.ImageOptions.Image")));
            this.btngüncelle.Location = new System.Drawing.Point(35, 694);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(147, 50);
            this.btngüncelle.TabIndex = 11;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(200, 638);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(137, 49);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "SİL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(35, 637);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(147, 50);
            this.btnkaydet.TabIndex = 9;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(78, 291);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(53, 22);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "IBAN :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(103, 152);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 22);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "İL :";
            // 
            // txtyetkili
            // 
            this.txtyetkili.Location = new System.Drawing.Point(143, 391);
            this.txtyetkili.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtyetkili.Name = "txtyetkili";
            this.txtyetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyetkili.Properties.Appearance.Options.UseFont = true;
            this.txtyetkili.Size = new System.Drawing.Size(194, 28);
            this.txtyetkili.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(45, 445);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 22);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "TELEFON :";
            // 
            // txtşube
            // 
            this.txtşube.Location = new System.Drawing.Point(143, 243);
            this.txtşube.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtşube.Name = "txtşube";
            this.txtşube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtşube.Properties.Appearance.Options.UseFont = true;
            this.txtşube.Size = new System.Drawing.Size(198, 28);
            this.txtşube.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(76, 246);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 22);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "ŞUBE :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(143, 102);
            this.txtad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtad.Name = "txtad";
            this.txtad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Properties.Appearance.Options.UseFont = true;
            this.txtad.Size = new System.Drawing.Size(196, 28);
            this.txtad.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 105);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "BANKA ADI :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(143, 57);
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
            this.labelControl1.Location = new System.Drawing.Point(100, 60);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.msktarih);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txthesaptürü);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.mskhesapno);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtyetkili);
            this.groupControl1.Controls.Add(this.cmbilçe);
            this.groupControl1.Controls.Add(this.mskıban);
            this.groupControl1.Controls.Add(this.txtşube);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cmbil);
            this.groupControl1.Controls.Add(this.msktel1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btngüncelle);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1704, -2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(347, 774);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "BANKA İŞLEMLERİ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(200, 694);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 50);
            this.simpleButton1.TabIndex = 46;
            this.simpleButton1.Text = "TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(143, 578);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "Bir Firma Seçin";
            this.lookUpEdit1.Size = new System.Drawing.Size(194, 28);
            this.lookUpEdit1.TabIndex = 45;
            // 
            // msktarih
            // 
            this.msktarih.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktarih.Location = new System.Drawing.Point(143, 487);
            this.msktarih.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(196, 29);
            this.msktarih.TabIndex = 44;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(67, 584);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 22);
            this.labelControl8.TabIndex = 43;
            this.labelControl8.Text = "FİRMA :";
            // 
            // txthesaptürü
            // 
            this.txthesaptürü.Location = new System.Drawing.Point(143, 531);
            this.txthesaptürü.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txthesaptürü.Name = "txthesaptürü";
            this.txthesaptürü.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthesaptürü.Properties.Appearance.Options.UseFont = true;
            this.txthesaptürü.Size = new System.Drawing.Size(194, 28);
            this.txthesaptürü.TabIndex = 40;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(14, 534);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(117, 22);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "HESAP TÜRÜ :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(67, 487);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 22);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "TARİH :";
            // 
            // mskhesapno
            // 
            this.mskhesapno.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskhesapno.Location = new System.Drawing.Point(143, 339);
            this.mskhesapno.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(194, 29);
            this.mskhesapno.TabIndex = 37;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(35, 339);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(96, 22);
            this.labelControl12.TabIndex = 36;
            this.labelControl12.Text = "HESAP NO :";
            // 
            // frmbankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 768);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmbankalar";
            this.Text = "BANKALAR";
            this.Load += new System.EventHandler(this.frmbankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilçe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtşube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthesaptürü.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit cmbilçe;
        private DevExpress.XtraEditors.ComboBoxEdit cmbil;
        private System.Windows.Forms.MaskedTextBox mskıban;
        private System.Windows.Forms.MaskedTextBox msktel1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btngüncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtyetkili;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtşube;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txthesaptürü;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}