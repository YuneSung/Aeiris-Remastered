﻿//Copyright 2017 Andrea Fioraldi <andreafioraldi@gmail.com>

//Aeiris is free software; you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation; either version 3 of the License, or
//(at your option) any later version.

//Stout Compiler is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
//MA 02110-1301, USA.

namespace Aeiris
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.menuSaveAs = new System.Windows.Forms.MenuItem();
            this.menuReset = new System.Windows.Forms.MenuItem();
            this.menuClose = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuEdit = new System.Windows.Forms.MenuItem();
            this.menuCut = new System.Windows.Forms.MenuItem();
            this.menuCopy = new System.Windows.Forms.MenuItem();
            this.menuPaste = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuCopyHex = new System.Windows.Forms.MenuItem();
            this.menuSelectAll = new System.Windows.Forms.MenuItem();
            this.menuDelete = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuFind = new System.Windows.Forms.MenuItem();
            this.menuFindNext = new System.Windows.Forms.MenuItem();
            this.menuReplace = new System.Windows.Forms.MenuItem();
            this.menuGoto = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuInsert = new System.Windows.Forms.MenuItem();
            this.menuTools = new System.Windows.Forms.MenuItem();
            this.menuCalculator = new System.Windows.Forms.MenuItem();
            this.menuConverter = new System.Windows.Forms.MenuItem();
            this.menuInfo = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.menuLicense = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dragDropLbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.Interpretation = new System.Windows.Forms.TabPage();
            this.calcUTFnBinBox = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.unicodeBox = new System.Windows.Forms.TextBox();
            this.f64Box = new System.Windows.Forms.TextBox();
            this.f32Box = new System.Windows.Forms.TextBox();
            this.binBox = new System.Windows.Forms.TextBox();
            this.u64Box = new System.Windows.Forms.TextBox();
            this.i64Box = new System.Windows.Forms.TextBox();
            this.u8Box = new System.Windows.Forms.TextBox();
            this.i8Box = new System.Windows.Forms.TextBox();
            this.u32Box = new System.Windows.Forms.TextBox();
            this.i32Box = new System.Windows.Forms.TextBox();
            this.u16Box = new System.Windows.Forms.TextBox();
            this.i16Box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.littleEndianBox = new System.Windows.Forms.CheckBox();
            this.selectedLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StringsPage = new System.Windows.Forms.TabPage();
            this.saveListBtn = new System.Windows.Forms.Button();
            this.stringsList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchStrBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.strMinimumBox = new System.Windows.Forms.NumericUpDown();
            this.alphanumAsciiBox = new System.Windows.Forms.RadioButton();
            this.extAsciiBox = new System.Windows.Forms.RadioButton();
            this.AsciiBox = new System.Windows.Forms.RadioButton();
            this.EditPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.hex = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.Interpretation.SuspendLayout();
            this.StringsPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strMinimumBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuTools,
            this.menuInfo,
            this.menuItem6});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOpen,
            this.menuSave,
            this.menuSaveAs,
            this.menuReset,
            this.menuClose,
            this.menuItem1,
            this.menuItem2});
            this.menuFile.Text = "File";
            // 
            // menuOpen
            // 
            this.menuOpen.Index = 0;
            this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Enabled = false;
            this.menuSave.Index = 1;
            this.menuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Enabled = false;
            this.menuSaveAs.Index = 2;
            this.menuSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.menuSaveAs.Text = "Save as";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // menuReset
            // 
            this.menuReset.Enabled = false;
            this.menuReset.Index = 3;
            this.menuReset.Text = "Reset";
            this.menuReset.Click += new System.EventHandler(this.menuReset_Click);
            // 
            // menuClose
            // 
            this.menuClose.Enabled = false;
            this.menuClose.Index = 4;
            this.menuClose.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
            this.menuClose.Text = "Close";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 5;
            this.menuItem1.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 6;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItem2.Text = "Exit";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Enabled = false;
            this.menuEdit.Index = 1;
            this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuCut,
            this.menuCopy,
            this.menuPaste,
            this.menuItem3,
            this.menuCopyHex,
            this.menuSelectAll,
            this.menuDelete,
            this.menuItem4,
            this.menuFind,
            this.menuFindNext,
            this.menuReplace,
            this.menuGoto,
            this.menuItem5,
            this.menuInsert});
            this.menuEdit.Text = "Edit";
            // 
            // menuCut
            // 
            this.menuCut.Index = 0;
            this.menuCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuCut.Text = "Cut";
            this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
            // 
            // menuCopy
            // 
            this.menuCopy.Index = 1;
            this.menuCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuCopy.Text = "Copy";
            this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Index = 2;
            this.menuPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuPaste.Text = "Paste";
            this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "-";
            // 
            // menuCopyHex
            // 
            this.menuCopyHex.Index = 4;
            this.menuCopyHex.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftC;
            this.menuCopyHex.Text = "Copy Hex";
            this.menuCopyHex.Click += new System.EventHandler(this.menuCopyHex_Click);
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Index = 5;
            this.menuSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuSelectAll.Text = "Select all";
            this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Index = 6;
            this.menuDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.menuDelete.Text = "Delete";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 7;
            this.menuItem4.Text = "-";
            // 
            // menuFind
            // 
            this.menuFind.Index = 8;
            this.menuFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.menuFind.Text = "Find";
            this.menuFind.Click += new System.EventHandler(this.menuFind_Click);
            // 
            // menuFindNext
            // 
            this.menuFindNext.Index = 9;
            this.menuFindNext.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.menuFindNext.Text = "Find next";
            this.menuFindNext.Click += new System.EventHandler(this.menuFindNext_Click);
            // 
            // menuReplace
            // 
            this.menuReplace.Index = 10;
            this.menuReplace.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.menuReplace.Text = "Replace";
            this.menuReplace.Click += new System.EventHandler(this.menuReplace_Click);
            // 
            // menuGoto
            // 
            this.menuGoto.Index = 11;
            this.menuGoto.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.menuGoto.Text = "Goto";
            this.menuGoto.Click += new System.EventHandler(this.menuGoto_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 12;
            this.menuItem5.Text = "-";
            // 
            // menuInsert
            // 
            this.menuInsert.Index = 13;
            this.menuInsert.Shortcut = System.Windows.Forms.Shortcut.Ins;
            this.menuInsert.Text = "Insert mode";
            this.menuInsert.Click += new System.EventHandler(this.menuInsert_Click);
            // 
            // menuTools
            // 
            this.menuTools.Index = 2;
            this.menuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuCalculator,
            this.menuConverter});
            this.menuTools.Text = "Tools";
            // 
            // menuCalculator
            // 
            this.menuCalculator.Index = 0;
            this.menuCalculator.Text = "Calculator";
            this.menuCalculator.Click += new System.EventHandler(this.menuCalculator_Click);
            // 
            // menuConverter
            // 
            this.menuConverter.Index = 1;
            this.menuConverter.Text = "Converter";
            this.menuConverter.Click += new System.EventHandler(this.menuConverter_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.Index = 3;
            this.menuInfo.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuAbout,
            this.menuLicense});
            this.menuInfo.Text = "Info";
            // 
            // menuAbout
            // 
            this.menuAbout.Index = 0;
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuLicense
            // 
            this.menuLicense.Index = 1;
            this.menuLicense.Text = "License";
            this.menuLicense.Click += new System.EventHandler(this.menuLicense_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dragDropLbl
            // 
            this.dragDropLbl.AllowDrop = true;
            this.dragDropLbl.BackColor = System.Drawing.SystemColors.Control;
            this.dragDropLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragDropLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dragDropLbl.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragDropLbl.ForeColor = System.Drawing.Color.Black;
            this.dragDropLbl.Location = new System.Drawing.Point(724, 33);
            this.dragDropLbl.Name = "dragDropLbl";
            this.dragDropLbl.Size = new System.Drawing.Size(296, 385);
            this.dragDropLbl.TabIndex = 0;
            this.dragDropLbl.Text = "Drag and drop a file here";
            this.dragDropLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dragDropLbl.Click += new System.EventHandler(this.dragDropLbl_Click);
            this.dragDropLbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropLbl_DragDrop);
            this.dragDropLbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDropLbl_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 523);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Unity Manager";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Unity Manager Not Found!";
            // 
            // Interpretation
            // 
            this.Interpretation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Interpretation.Controls.Add(this.calcUTFnBinBox);
            this.Interpretation.Controls.Add(this.label14);
            this.Interpretation.Controls.Add(this.unicodeBox);
            this.Interpretation.Controls.Add(this.f64Box);
            this.Interpretation.Controls.Add(this.f32Box);
            this.Interpretation.Controls.Add(this.binBox);
            this.Interpretation.Controls.Add(this.u64Box);
            this.Interpretation.Controls.Add(this.i64Box);
            this.Interpretation.Controls.Add(this.u8Box);
            this.Interpretation.Controls.Add(this.i8Box);
            this.Interpretation.Controls.Add(this.u32Box);
            this.Interpretation.Controls.Add(this.i32Box);
            this.Interpretation.Controls.Add(this.u16Box);
            this.Interpretation.Controls.Add(this.i16Box);
            this.Interpretation.Controls.Add(this.label12);
            this.Interpretation.Controls.Add(this.label13);
            this.Interpretation.Controls.Add(this.label11);
            this.Interpretation.Controls.Add(this.label9);
            this.Interpretation.Controls.Add(this.label10);
            this.Interpretation.Controls.Add(this.label7);
            this.Interpretation.Controls.Add(this.label8);
            this.Interpretation.Controls.Add(this.label6);
            this.Interpretation.Controls.Add(this.label5);
            this.Interpretation.Controls.Add(this.label4);
            this.Interpretation.Controls.Add(this.label3);
            this.Interpretation.Controls.Add(this.littleEndianBox);
            this.Interpretation.Controls.Add(this.selectedLbl);
            this.Interpretation.Controls.Add(this.label2);
            this.Interpretation.Location = new System.Drawing.Point(4, 29);
            this.Interpretation.Name = "Interpretation";
            this.Interpretation.Padding = new System.Windows.Forms.Padding(3);
            this.Interpretation.Size = new System.Drawing.Size(703, 523);
            this.Interpretation.TabIndex = 2;
            this.Interpretation.Text = "Interpretation";
            this.Interpretation.UseVisualStyleBackColor = true;
            this.Interpretation.Enter += new System.EventHandler(this.Interpretation_Enter);
            // 
            // calcUTFnBinBox
            // 
            this.calcUTFnBinBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calcUTFnBinBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calcUTFnBinBox.Location = new System.Drawing.Point(299, 450);
            this.calcUTFnBinBox.Name = "calcUTFnBinBox";
            this.calcUTFnBinBox.Size = new System.Drawing.Size(395, 71);
            this.calcUTFnBinBox.TabIndex = 27;
            this.calcUTFnBinBox.Text = "Calculate UTF16 and binary";
            this.calcUTFnBinBox.UseVisualStyleBackColor = true;
            this.calcUTFnBinBox.Click += new System.EventHandler(this.calcUTFnBinBox_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "UTF16 string";
            // 
            // unicodeBox
            // 
            this.unicodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.unicodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unicodeBox.Location = new System.Drawing.Point(7, 201);
            this.unicodeBox.Multiline = true;
            this.unicodeBox.Name = "unicodeBox";
            this.unicodeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unicodeBox.Size = new System.Drawing.Size(277, 243);
            this.unicodeBox.TabIndex = 25;
            // 
            // f64Box
            // 
            this.f64Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f64Box.Location = new System.Drawing.Point(153, 138);
            this.f64Box.Name = "f64Box";
            this.f64Box.Size = new System.Drawing.Size(135, 24);
            this.f64Box.TabIndex = 23;
            // 
            // f32Box
            // 
            this.f32Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f32Box.Location = new System.Drawing.Point(7, 138);
            this.f32Box.Name = "f32Box";
            this.f32Box.Size = new System.Drawing.Size(135, 24);
            this.f32Box.TabIndex = 21;
            // 
            // binBox
            // 
            this.binBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.binBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.binBox.Location = new System.Drawing.Point(299, 138);
            this.binBox.Multiline = true;
            this.binBox.Name = "binBox";
            this.binBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.binBox.Size = new System.Drawing.Size(395, 306);
            this.binBox.TabIndex = 19;
            // 
            // u64Box
            // 
            this.u64Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u64Box.Location = new System.Drawing.Point(444, 82);
            this.u64Box.Name = "u64Box";
            this.u64Box.Size = new System.Drawing.Size(250, 24);
            this.u64Box.TabIndex = 17;
            // 
            // i64Box
            // 
            this.i64Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.i64Box.Location = new System.Drawing.Point(299, 82);
            this.i64Box.Name = "i64Box";
            this.i64Box.Size = new System.Drawing.Size(135, 24);
            this.i64Box.TabIndex = 15;
            // 
            // u8Box
            // 
            this.u8Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u8Box.Location = new System.Drawing.Point(153, 23);
            this.u8Box.Name = "u8Box";
            this.u8Box.Size = new System.Drawing.Size(135, 24);
            this.u8Box.TabIndex = 13;
            // 
            // i8Box
            // 
            this.i8Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.i8Box.Location = new System.Drawing.Point(7, 23);
            this.i8Box.Name = "i8Box";
            this.i8Box.Size = new System.Drawing.Size(135, 24);
            this.i8Box.TabIndex = 11;
            // 
            // u32Box
            // 
            this.u32Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u32Box.Location = new System.Drawing.Point(444, 23);
            this.u32Box.Name = "u32Box";
            this.u32Box.Size = new System.Drawing.Size(250, 24);
            this.u32Box.TabIndex = 9;
            // 
            // i32Box
            // 
            this.i32Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.i32Box.Location = new System.Drawing.Point(299, 23);
            this.i32Box.Name = "i32Box";
            this.i32Box.Size = new System.Drawing.Size(135, 24);
            this.i32Box.TabIndex = 7;
            // 
            // u16Box
            // 
            this.u16Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u16Box.Location = new System.Drawing.Point(153, 82);
            this.u16Box.Name = "u16Box";
            this.u16Box.Size = new System.Drawing.Size(135, 24);
            this.u16Box.TabIndex = 5;
            // 
            // i16Box
            // 
            this.i16Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.i16Box.Location = new System.Drawing.Point(7, 82);
            this.i16Box.Name = "i16Box";
            this.i16Box.Size = new System.Drawing.Size(135, 24);
            this.i16Box.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "64 bit float";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "32 bit float";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Binary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Unsigned 64 bit int";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Signed 64 bit int";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Unsigned 8 bit int";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Signed 8 bit int";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Unsigned 32 bit int";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Signed 32 bit int";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unsigned 16 bit int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Signed 16 bit int";
            // 
            // littleEndianBox
            // 
            this.littleEndianBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.littleEndianBox.AutoSize = true;
            this.littleEndianBox.Checked = true;
            this.littleEndianBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.littleEndianBox.Location = new System.Drawing.Point(10, 468);
            this.littleEndianBox.Name = "littleEndianBox";
            this.littleEndianBox.Size = new System.Drawing.Size(99, 20);
            this.littleEndianBox.TabIndex = 3;
            this.littleEndianBox.Text = "Little Endian";
            this.littleEndianBox.UseVisualStyleBackColor = true;
            this.littleEndianBox.CheckedChanged += new System.EventHandler(this.littleEndianBox_CheckedChanged);
            // 
            // selectedLbl
            // 
            this.selectedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedLbl.Location = new System.Drawing.Point(134, 451);
            this.selectedLbl.Name = "selectedLbl";
            this.selectedLbl.Size = new System.Drawing.Size(144, 21);
            this.selectedLbl.TabIndex = 1;
            this.selectedLbl.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Processed bytes:";
            // 
            // StringsPage
            // 
            this.StringsPage.Controls.Add(this.saveListBtn);
            this.StringsPage.Controls.Add(this.stringsList);
            this.StringsPage.Controls.Add(this.panel1);
            this.StringsPage.Controls.Add(this.alphanumAsciiBox);
            this.StringsPage.Controls.Add(this.extAsciiBox);
            this.StringsPage.Controls.Add(this.AsciiBox);
            this.StringsPage.Location = new System.Drawing.Point(4, 29);
            this.StringsPage.Name = "StringsPage";
            this.StringsPage.Padding = new System.Windows.Forms.Padding(3);
            this.StringsPage.Size = new System.Drawing.Size(703, 523);
            this.StringsPage.TabIndex = 1;
            this.StringsPage.Text = "Strings";
            this.StringsPage.UseVisualStyleBackColor = true;
            // 
            // saveListBtn
            // 
            this.saveListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveListBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveListBtn.Location = new System.Drawing.Point(428, 487);
            this.saveListBtn.Name = "saveListBtn";
            this.saveListBtn.Size = new System.Drawing.Size(271, 27);
            this.saveListBtn.TabIndex = 11;
            this.saveListBtn.Text = "Save list";
            this.saveListBtn.UseVisualStyleBackColor = true;
            this.saveListBtn.Click += new System.EventHandler(this.saveListBtn_Click);
            // 
            // stringsList
            // 
            this.stringsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stringsList.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringsList.FormattingEnabled = true;
            this.stringsList.ItemHeight = 19;
            this.stringsList.Location = new System.Drawing.Point(3, 40);
            this.stringsList.Name = "stringsList";
            this.stringsList.Size = new System.Drawing.Size(698, 439);
            this.stringsList.TabIndex = 6;
            this.stringsList.SelectedIndexChanged += new System.EventHandler(this.stringsList_SelectedIndexChanged);
            this.stringsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.stringsList_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchStrBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.strMinimumBox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 59);
            this.panel1.TabIndex = 11;
            // 
            // searchStrBtn
            // 
            this.searchStrBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchStrBtn.Location = new System.Drawing.Point(3, 3);
            this.searchStrBtn.Name = "searchStrBtn";
            this.searchStrBtn.Size = new System.Drawing.Size(391, 27);
            this.searchStrBtn.TabIndex = 0;
            this.searchStrBtn.Text = "Search strings";
            this.searchStrBtn.UseVisualStyleBackColor = true;
            this.searchStrBtn.Click += new System.EventHandler(this.searchStrBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum number of characters:";
            // 
            // strMinimumBox
            // 
            this.strMinimumBox.Location = new System.Drawing.Point(642, 3);
            this.strMinimumBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.strMinimumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.strMinimumBox.Name = "strMinimumBox";
            this.strMinimumBox.Size = new System.Drawing.Size(59, 24);
            this.strMinimumBox.TabIndex = 4;
            this.strMinimumBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // alphanumAsciiBox
            // 
            this.alphanumAsciiBox.AutoSize = true;
            this.alphanumAsciiBox.Checked = true;
            this.alphanumAsciiBox.Location = new System.Drawing.Point(220, 490);
            this.alphanumAsciiBox.Name = "alphanumAsciiBox";
            this.alphanumAsciiBox.Size = new System.Drawing.Size(177, 20);
            this.alphanumAsciiBox.TabIndex = 10;
            this.alphanumAsciiBox.TabStop = true;
            this.alphanumAsciiBox.Text = "ASCII - only _0-9A-Za-z";
            this.alphanumAsciiBox.UseVisualStyleBackColor = true;
            // 
            // extAsciiBox
            // 
            this.extAsciiBox.AutoSize = true;
            this.extAsciiBox.Location = new System.Drawing.Point(79, 490);
            this.extAsciiBox.Name = "extAsciiBox";
            this.extAsciiBox.Size = new System.Drawing.Size(115, 20);
            this.extAsciiBox.TabIndex = 9;
            this.extAsciiBox.Text = "Extended ASCII";
            this.extAsciiBox.UseVisualStyleBackColor = true;
            // 
            // AsciiBox
            // 
            this.AsciiBox.AutoSize = true;
            this.AsciiBox.Location = new System.Drawing.Point(7, 490);
            this.AsciiBox.Name = "AsciiBox";
            this.AsciiBox.Size = new System.Drawing.Size(56, 20);
            this.AsciiBox.TabIndex = 8;
            this.AsciiBox.Text = "ASCII";
            this.AsciiBox.UseVisualStyleBackColor = true;
            // 
            // EditPage
            // 
            this.EditPage.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPage.ForeColor = System.Drawing.Color.Violet;
            this.EditPage.Location = new System.Drawing.Point(4, 29);
            this.EditPage.Name = "EditPage";
            this.EditPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditPage.Size = new System.Drawing.Size(703, 523);
            this.EditPage.TabIndex = 0;
            this.EditPage.Text = "Editor";
            this.EditPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EditPage);
            this.tabControl1.Controls.Add(this.StringsPage);
            this.tabControl1.Controls.Add(this.Interpretation);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(97, 25);
            this.tabControl1.Location = new System.Drawing.Point(7, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(18, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 556);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 523);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Unreal Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Unreal Manager Not Found!";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.tabPage3.Size = new System.Drawing.Size(703, 523);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Options++";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(4, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "UnrealDev";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(4, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "FCL";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(4, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 19);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "UnityDevH Default";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Green;
            this.radioButton4.Location = new System.Drawing.Point(4, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 19);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Default";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.ForeColor = System.Drawing.Color.Black;
            this.hex.Location = new System.Drawing.Point(4, 30);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(89, 19);
            this.hex.TabIndex = 7;
            this.hex.Text = "C# Dev Kit";
            this.hex.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.ForeColor = System.Drawing.Color.Black;
            this.radioButton5.Location = new System.Drawing.Point(3, 8);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(93, 19);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "C++ Dev Kit";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Location = new System.Drawing.Point(724, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 132);
            this.panel2.TabIndex = 10;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.Color.Black;
            this.radioButton6.Location = new System.Drawing.Point(232, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 19);
            this.radioButton6.TabIndex = 9;
            this.radioButton6.Text = "Lua/J";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hex);
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Location = new System.Drawing.Point(185, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 56);
            this.panel3.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Options++ Not Found!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dragDropLbl);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(639, 416);
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.Text = "Aeiris: Remastered";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Interpretation.ResumeLayout(false);
            this.Interpretation.PerformLayout();
            this.StringsPage.ResumeLayout(false);
            this.StringsPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strMinimumBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuFile;
        private System.Windows.Forms.MenuItem menuOpen;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.MenuItem menuSaveAs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuItem menuEdit;
        private System.Windows.Forms.MenuItem menuReset;
        private System.Windows.Forms.MenuItem menuClose;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuItem menuCut;
        private System.Windows.Forms.MenuItem menuCopy;
        private System.Windows.Forms.MenuItem menuPaste;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuCopyHex;
        private System.Windows.Forms.MenuItem menuSelectAll;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuFind;
        private System.Windows.Forms.MenuItem menuReplace;
        private System.Windows.Forms.MenuItem menuTools;
        private System.Windows.Forms.MenuItem menuInfo;
        private System.Windows.Forms.MenuItem menuAbout;
        private System.Windows.Forms.MenuItem menuLicense;
        private System.Windows.Forms.MenuItem menuCalculator;
        private System.Windows.Forms.MenuItem menuGoto;
        private System.Windows.Forms.Label dragDropLbl;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuInsert;
        private System.Windows.Forms.MenuItem menuDelete;
        private System.Windows.Forms.MenuItem menuFindNext;
        private System.Windows.Forms.MenuItem menuConverter;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Interpretation;
        private System.Windows.Forms.Button calcUTFnBinBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox unicodeBox;
        private System.Windows.Forms.TextBox f64Box;
        private System.Windows.Forms.TextBox f32Box;
        private System.Windows.Forms.TextBox binBox;
        private System.Windows.Forms.TextBox u64Box;
        private System.Windows.Forms.TextBox i64Box;
        private System.Windows.Forms.TextBox u8Box;
        private System.Windows.Forms.TextBox i8Box;
        private System.Windows.Forms.TextBox u32Box;
        private System.Windows.Forms.TextBox i32Box;
        private System.Windows.Forms.TextBox u16Box;
        private System.Windows.Forms.TextBox i16Box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox littleEndianBox;
        private System.Windows.Forms.Label selectedLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage StringsPage;
        private System.Windows.Forms.Button saveListBtn;
        private System.Windows.Forms.ListBox stringsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchStrBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown strMinimumBox;
        private System.Windows.Forms.RadioButton alphanumAsciiBox;
        private System.Windows.Forms.RadioButton extAsciiBox;
        private System.Windows.Forms.RadioButton AsciiBox;
        private System.Windows.Forms.TabPage EditPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton hex;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label17;
    }
}

