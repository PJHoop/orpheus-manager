﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrpheusManager
{
    public partial class newCharacter : Form
    {
        public newCharacter()
        {
            InitializeComponent();
        }

        private void nCharSubmit_Click(object sender, EventArgs e)
        {
            bool good = true;

            if (nCharName.Text.Length <= 0)
            {
                nCharAlert.Text = "Invalid Character Name";
                good = false;
            }

            if (good)
            {
                CDATA.cName = nCharName.Text;
                CDATA.cArch1 = nCharArch1.Text;
                CDATA.cArch2 = nCharArch2.Text;
                CDATA.cArch3 = nCharArch3.Text;
                CDATA.cBackground = nCharBackground.Text;
                CDATA.cMot1 = nCharMot1.Text;
                CDATA.cMot2 = nCharMot2.Text;
                CDATA.cMot3 = nCharMot3.Text;
                Int32.TryParse(nCharLv.Text, out CDATA.cLevel);
                Int32.TryParse(nCharPer.Text, out CDATA.cAttributes[0]);
                Int32.TryParse(nCharCog.Text, out CDATA.cAttributes[1]);
                Int32.TryParse(nCharDex.Text, out CDATA.cAttributes[2]);
                Int32.TryParse(nCharVit.Text, out CDATA.cAttributes[3]);
                Int32.TryParse(nCharChar.Text, out CDATA.cAttributes[4]);
                Int32.TryParse(nCharWill.Text, out CDATA.cAttributes[5]);
                this.Close();
            }
        }

        private void nCharCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
