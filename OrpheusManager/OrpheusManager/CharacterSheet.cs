﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.IO;

namespace OrpheusManager
{
    public partial class CharacterSheet : Form
    {
        public CharacterSheet()
        {
            InitializeComponent();
        }

        public static void outsideWrite()
        {
            //writeDATA();
        }

        // Update Character Sheet
        public void writeDATA()
        {
            // Window Settings
            this.Text = "Orpheus Manager - " + CDATA.cName;

            // Load CDATA
            cName.Text = CDATA.cName;
            cLevel.Text = "Lv. " + CDATA.cLevel;
            cArch1.Text = CDATA.cArch1;
            cArch2.Text = CDATA.cArch2;
            cArch3.Text = CDATA.cArch3;
            cPerception.Text = CDATA.cAttributes[0] + "";
            cCognition.Text = CDATA.cAttributes[1] + "";
            cDexterity.Text = CDATA.cAttributes[2] + "";
            cVitality.Text = CDATA.cAttributes[3] + "";
            cCharisma.Text = CDATA.cAttributes[4] + "";
            cWillpower.Text = CDATA.cAttributes[5] + "";
            cMot1.Text = CDATA.cMot1;
            cMot2.Text = CDATA.cMot2;
            cMot3.Text = CDATA.cMot3;
            cBackground.Text = "Background:\n" + CDATA.cBackground;
            cHumanityMax.Text = "/ " + CDATA.cHumanityMax;

            // Load DDATA
            DDATA.deriveDATA();
            if (DDATA.dMeleeAttTemp > 0) dMeleeAtt.Text = DDATA.dMeleeAtt + " + " + DDATA.dMeleeAttTemp;
            else if (DDATA.dMeleeAttTemp < 0) dMeleeAtt.Text = DDATA.dMeleeAtt + " - " + Math.Abs(DDATA.dMeleeAttTemp);
            else dMeleeAtt.Text = DDATA.dMeleeAtt + "";
            if (DDATA.dRangedAttTemp > 0) dRangedAtt.Text = DDATA.dRangedAtt + " + " + DDATA.dRangedAttTemp;
            else if (DDATA.dRangedAttTemp < 0) dRangedAtt.Text = DDATA.dRangedAtt + " - " + Math.Abs(DDATA.dRangedAttTemp);
            else dRangedAtt.Text = DDATA.dRangedAtt + "";
            if (DDATA.dSpeedTemp > 0) dSpeed.Text = DDATA.dSpeed + " + " + DDATA.dSpeedTemp;
            else if (DDATA.dSpeedTemp < 0) dSpeed.Text = DDATA.dSpeed + " - " + Math.Abs(DDATA.dSpeedTemp);
            else dSpeed.Text = DDATA.dSpeed + "";
            if (DDATA.dClarityTemp > 0) dClarity.Text = DDATA.dClarity + " + " + DDATA.dClarityTemp;
            else if (DDATA.dClarityTemp < 0) dClarity.Text = DDATA.dClarity + " - " + Math.Abs(DDATA.dClarityTemp);
            else dClarity.Text = DDATA.dClarity + "";
            if (DDATA.dToughnessTemp > 0) dToughness.Text = DDATA.dToughness + " + " + DDATA.dToughnessTemp;
            else if (DDATA.dToughnessTemp < 0) dToughness.Text = DDATA.dToughness + " - " + Math.Abs(DDATA.dToughnessTemp);
            else dToughness.Text = DDATA.dToughness + "";
            if (DDATA.dForceOfWillTemp > 0) dForceOfWill.Text = DDATA.dForceOfWill + " + " + DDATA.dForceOfWillTemp;
            else if (DDATA.dForceOfWillTemp < 0) dForceOfWill.Text = DDATA.dForceOfWill + " - " + Math.Abs(DDATA.dForceOfWillTemp);
            else dForceOfWill.Text = DDATA.dForceOfWill + "";
            if (DDATA.dInitiativeTemp > 0) dInitiative.Text = DDATA.dInitiative + " + " + DDATA.dInitiativeTemp;
            else if (DDATA.dInitiativeTemp < 0) dInitiative.Text = DDATA.dInitiative + " - " + Math.Abs(DDATA.dInitiativeTemp);
            else dInitiative.Text = DDATA.dInitiative + "";
            dMentalStrainMax.Text = "/ " + DDATA.dMentalStrainMax;
            dPhysicalStrainMax.Text = "/ " + DDATA.dPhysicalStrainMax;
            dSpiritualStrainMax.Text = "/ " + DDATA.dSpiritualStrainMax;

            // Configure Wound Meters
            if (CDATA.cAttributes[1] == 0)
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = false;
                FW7.Visible = false;
                FW8.Visible = false;
                FW9.Visible = false;
                FW10.Visible = false;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Flat;
                FW4.FlatStyle = FlatStyle.Flat;
                FW5.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[1] == 1)
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = true;
                FW7.Visible = false;
                FW8.Visible = false;
                FW9.Visible = false;
                FW10.Visible = false;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Standard;
                FW4.FlatStyle = FlatStyle.Flat;
                FW5.FlatStyle = FlatStyle.Flat;
                FW6.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[1] == 2)
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = true;
                FW7.Visible = true;
                FW8.Visible = false;
                FW9.Visible = false;
                FW10.Visible = false;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Standard;
                FW4.FlatStyle = FlatStyle.Flat;
                FW5.FlatStyle = FlatStyle.Flat;
                FW6.FlatStyle = FlatStyle.Flat;
                FW7.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[1] == 3)
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = true;
                FW7.Visible = true;
                FW8.Visible = true;
                FW9.Visible = false;
                FW10.Visible = false;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Standard;
                FW4.FlatStyle = FlatStyle.Flat;
                FW5.FlatStyle = FlatStyle.Flat;
                FW6.FlatStyle = FlatStyle.Flat;
                FW7.FlatStyle = FlatStyle.Standard;
                FW8.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[1] == 4)
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = true;
                FW7.Visible = true;
                FW8.Visible = true;
                FW9.Visible = true;
                FW10.Visible = false;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Standard;
                FW4.FlatStyle = FlatStyle.Standard;
                FW5.FlatStyle = FlatStyle.Flat;
                FW6.FlatStyle = FlatStyle.Flat;
                FW7.FlatStyle = FlatStyle.Flat;
                FW8.FlatStyle = FlatStyle.Standard;
                FW9.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                FW1.Visible = true;
                FW2.Visible = true;
                FW3.Visible = true;
                FW4.Visible = true;
                FW5.Visible = true;
                FW6.Visible = true;
                FW7.Visible = true;
                FW8.Visible = true;
                FW9.Visible = true;
                FW10.Visible = true;
                FW1.FlatStyle = FlatStyle.Standard;
                FW2.FlatStyle = FlatStyle.Standard;
                FW3.FlatStyle = FlatStyle.Standard;
                FW4.FlatStyle = FlatStyle.Standard;
                FW5.FlatStyle = FlatStyle.Flat;
                FW6.FlatStyle = FlatStyle.Flat;
                FW7.FlatStyle = FlatStyle.Flat;
                FW8.FlatStyle = FlatStyle.Flat;
                FW9.FlatStyle = FlatStyle.Standard;
                FW10.FlatStyle = FlatStyle.Standard;
            }

            if (CDATA.cAttributes[3] == 0)
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = false;
                HW7.Visible = false;
                HW8.Visible = false;
                HW9.Visible = false;
                HW10.Visible = false;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Flat;
                HW4.FlatStyle = FlatStyle.Flat;
                HW5.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[3] == 1)
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = true;
                HW7.Visible = false;
                HW8.Visible = false;
                HW9.Visible = false;
                HW10.Visible = false;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Standard;
                HW4.FlatStyle = FlatStyle.Flat;
                HW5.FlatStyle = FlatStyle.Flat;
                HW6.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[3] == 2)
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = true;
                HW7.Visible = true;
                HW8.Visible = false;
                HW9.Visible = false;
                HW10.Visible = false;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Standard;
                HW4.FlatStyle = FlatStyle.Flat;
                HW5.FlatStyle = FlatStyle.Flat;
                HW6.FlatStyle = FlatStyle.Flat;
                HW7.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[3] == 3)
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = true;
                HW7.Visible = true;
                HW8.Visible = true;
                HW9.Visible = false;
                HW10.Visible = false;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Standard;
                HW4.FlatStyle = FlatStyle.Flat;
                HW5.FlatStyle = FlatStyle.Flat;
                HW6.FlatStyle = FlatStyle.Flat;
                HW7.FlatStyle = FlatStyle.Standard;
                HW8.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[3] == 4)
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = true;
                HW7.Visible = true;
                HW8.Visible = true;
                HW9.Visible = true;
                HW10.Visible = false;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Standard;
                HW4.FlatStyle = FlatStyle.Standard;
                HW5.FlatStyle = FlatStyle.Flat;
                HW6.FlatStyle = FlatStyle.Flat;
                HW7.FlatStyle = FlatStyle.Flat;
                HW8.FlatStyle = FlatStyle.Standard;
                HW9.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                HW1.Visible = true;
                HW2.Visible = true;
                HW3.Visible = true;
                HW4.Visible = true;
                HW5.Visible = true;
                HW6.Visible = true;
                HW7.Visible = true;
                HW8.Visible = true;
                HW9.Visible = true;
                HW10.Visible = true;
                HW1.FlatStyle = FlatStyle.Standard;
                HW2.FlatStyle = FlatStyle.Standard;
                HW3.FlatStyle = FlatStyle.Standard;
                HW4.FlatStyle = FlatStyle.Standard;
                HW5.FlatStyle = FlatStyle.Flat;
                HW6.FlatStyle = FlatStyle.Flat;
                HW7.FlatStyle = FlatStyle.Flat;
                HW8.FlatStyle = FlatStyle.Flat;
                HW9.FlatStyle = FlatStyle.Standard;
                HW10.FlatStyle = FlatStyle.Standard;
            }

            if (CDATA.cAttributes[5] == 0)
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = false;
                SW7.Visible = false;
                SW8.Visible = false;
                SW9.Visible = false;
                SW10.Visible = false;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Flat;
                SW4.FlatStyle = FlatStyle.Flat;
                SW5.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[5] == 1)
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = true;
                SW7.Visible = false;
                SW8.Visible = false;
                SW9.Visible = false;
                SW10.Visible = false;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Standard;
                SW4.FlatStyle = FlatStyle.Flat;
                SW5.FlatStyle = FlatStyle.Flat;
                SW6.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[5] == 2)
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = true;
                SW7.Visible = true;
                SW8.Visible = false;
                SW9.Visible = false;
                SW10.Visible = false;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Standard;
                SW4.FlatStyle = FlatStyle.Flat;
                SW5.FlatStyle = FlatStyle.Flat;
                SW6.FlatStyle = FlatStyle.Flat;
                SW7.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[5] == 3)
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = true;
                SW7.Visible = true;
                SW8.Visible = true;
                SW9.Visible = false;
                SW10.Visible = false;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Standard;
                SW4.FlatStyle = FlatStyle.Flat;
                SW5.FlatStyle = FlatStyle.Flat;
                SW6.FlatStyle = FlatStyle.Flat;
                SW7.FlatStyle = FlatStyle.Standard;
                SW8.FlatStyle = FlatStyle.Standard;
            }
            else if (CDATA.cAttributes[5] == 4)
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = true;
                SW7.Visible = true;
                SW8.Visible = true;
                SW9.Visible = true;
                SW10.Visible = false;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Standard;
                SW4.FlatStyle = FlatStyle.Standard;
                SW5.FlatStyle = FlatStyle.Flat;
                SW6.FlatStyle = FlatStyle.Flat;
                SW7.FlatStyle = FlatStyle.Flat;
                SW8.FlatStyle = FlatStyle.Standard;
                SW9.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                SW1.Visible = true;
                SW2.Visible = true;
                SW3.Visible = true;
                SW4.Visible = true;
                SW5.Visible = true;
                SW6.Visible = true;
                SW7.Visible = true;
                SW8.Visible = true;
                SW9.Visible = true;
                SW10.Visible = true;
                SW1.FlatStyle = FlatStyle.Standard;
                SW2.FlatStyle = FlatStyle.Standard;
                SW3.FlatStyle = FlatStyle.Standard;
                SW4.FlatStyle = FlatStyle.Standard;
                SW5.FlatStyle = FlatStyle.Flat;
                SW6.FlatStyle = FlatStyle.Flat;
                SW7.FlatStyle = FlatStyle.Flat;
                SW8.FlatStyle = FlatStyle.Flat;
                SW9.FlatStyle = FlatStyle.Standard;
                SW10.FlatStyle = FlatStyle.Standard;
            }

            // Skill Display
            s1.Text = CDATA.cSkillName[0];
            s2.Text = CDATA.cSkillName[1];
            s3.Text = CDATA.cSkillName[2];
            s4.Text = CDATA.cSkillName[3];
            s5.Text = CDATA.cSkillName[4];
            s6.Text = CDATA.cSkillName[5];
            s7.Text = CDATA.cSkillName[6];
            s8.Text = CDATA.cSkillName[7];
            s9.Text = CDATA.cSkillName[8];
            s10.Text = CDATA.cSkillName[9];
            s11.Text = CDATA.cSkillName[10];
            s12.Text = CDATA.cSkillName[11];
            s13.Text = CDATA.cSkillName[12];
            s14.Text = CDATA.cSkillName[13];
            s15.Text = CDATA.cSkillName[14];
            s16.Text = CDATA.cSkillName[15];
            s17.Text = CDATA.cSkillName[16];
            s18.Text = CDATA.cSkillName[17];
            s19.Text = CDATA.cSkillName[18];
            s20.Text = CDATA.cSkillName[19];
            s21.Text = CDATA.cSkillName[20];
            s22.Text = CDATA.cSkillName[21];

            sr1.Text = CDATA.cSkillRank[0];
            sr2.Text = CDATA.cSkillRank[1];
            sr3.Text = CDATA.cSkillRank[2];
            sr4.Text = CDATA.cSkillRank[3];
            sr5.Text = CDATA.cSkillRank[4];
            sr6.Text = CDATA.cSkillRank[5];
            sr7.Text = CDATA.cSkillRank[6];
            sr8.Text = CDATA.cSkillRank[7];
            sr9.Text = CDATA.cSkillRank[8];
            sr10.Text = CDATA.cSkillRank[9];
            sr11.Text = CDATA.cSkillRank[10];
            sr12.Text = CDATA.cSkillRank[11];
            sr13.Text = CDATA.cSkillRank[12];
            sr14.Text = CDATA.cSkillRank[13];
            sr15.Text = CDATA.cSkillRank[14];
            sr16.Text = CDATA.cSkillRank[15];
            sr17.Text = CDATA.cSkillRank[16];
            sr18.Text = CDATA.cSkillRank[17];
            sr19.Text = CDATA.cSkillRank[18];
            sr20.Text = CDATA.cSkillRank[19];
            sr21.Text = CDATA.cSkillRank[20];
            sr22.Text = CDATA.cSkillRank[21];

            c1.Text = CDATA.cCkillName[0];
            c2.Text = CDATA.cCkillName[1];
            c3.Text = CDATA.cCkillName[2];
            c4.Text = CDATA.cCkillName[3];
            c5.Text = CDATA.cCkillName[4];
            c6.Text = CDATA.cCkillName[5];
            c7.Text = CDATA.cCkillName[6];
            c8.Text = CDATA.cCkillName[7];
            c9.Text = CDATA.cCkillName[8];
            c10.Text = CDATA.cCkillName[9];
            c11.Text = CDATA.cCkillName[10];
            c12.Text = CDATA.cCkillName[11];
            c13.Text = CDATA.cCkillName[12];
            c14.Text = CDATA.cCkillName[13];
            c15.Text = CDATA.cCkillName[14];
            c16.Text = CDATA.cCkillName[15];
            c17.Text = CDATA.cCkillName[16];
            c18.Text = CDATA.cCkillName[17];
            c19.Text = CDATA.cCkillName[18];
            c20.Text = CDATA.cCkillName[19];
            c21.Text = CDATA.cCkillName[20];
            c22.Text = CDATA.cCkillName[21];

            cr1.Text = CDATA.cCkillRank[0];
            cr2.Text = CDATA.cCkillRank[1];
            cr3.Text = CDATA.cCkillRank[2];
            cr4.Text = CDATA.cCkillRank[3];
            cr5.Text = CDATA.cCkillRank[4];
            cr6.Text = CDATA.cCkillRank[5];
            cr7.Text = CDATA.cCkillRank[6];
            cr8.Text = CDATA.cCkillRank[7];
            cr9.Text = CDATA.cCkillRank[8];
            cr10.Text = CDATA.cCkillRank[9];
            cr11.Text = CDATA.cCkillRank[10];
            cr12.Text = CDATA.cCkillRank[11];
            cr13.Text = CDATA.cCkillRank[12];
            cr14.Text = CDATA.cCkillRank[13];
            cr15.Text = CDATA.cCkillRank[14];
            cr16.Text = CDATA.cCkillRank[15];
            cr17.Text = CDATA.cCkillRank[16];
            cr18.Text = CDATA.cCkillRank[17];
            cr19.Text = CDATA.cCkillRank[18];
            cr20.Text = CDATA.cCkillRank[19];
            cr21.Text = CDATA.cCkillRank[20];
            cr22.Text = CDATA.cCkillRank[21];
            
            // Ability Display
            a1.Text = CDATA.cAbilityName[0];
            a2.Text = CDATA.cAbilityName[1];
            a3.Text = CDATA.cAbilityName[2];
            a4.Text = CDATA.cAbilityName[3];
            a5.Text = CDATA.cAbilityName[4];
            a6.Text = CDATA.cAbilityName[5];
            a7.Text = CDATA.cAbilityName[6];
            a8.Text = CDATA.cAbilityName[7];
            a9.Text = CDATA.cAbilityName[8];
            a10.Text = CDATA.cAbilityName[9];
            a11.Text = CDATA.cAbilityName[10];
            a12.Text = CDATA.cAbilityName[11];

            ar1.Text = CDATA.cAbilityRank[0];
            ar2.Text = CDATA.cAbilityRank[1];
            ar3.Text = CDATA.cAbilityRank[2];
            ar4.Text = CDATA.cAbilityRank[3];
            ar5.Text = CDATA.cAbilityRank[4];
            ar6.Text = CDATA.cAbilityRank[5];
            ar7.Text = CDATA.cAbilityRank[6];
            ar8.Text = CDATA.cAbilityRank[7];
            ar9.Text = CDATA.cAbilityRank[8];
            ar10.Text = CDATA.cAbilityRank[9];
            ar11.Text = CDATA.cAbilityRank[10];
            ar12.Text = CDATA.cAbilityRank[11];
        }
        
        private void writeDATA2()
        {
            // Load Editable Fields
            if (CDATA.cAttributesTemp[0] == 0) mPerception.Text = "";
            else mPerception.Text = CDATA.cAttributesTemp[0] + "";
            if (CDATA.cAttributesTemp[1] == 0) mCognition.Text = "";
            else mCognition.Text = CDATA.cAttributesTemp[1] + "";
            if (CDATA.cAttributesTemp[2] == 0) mDexterity.Text = "";
            else mDexterity.Text = CDATA.cAttributesTemp[2] + "";
            if (CDATA.cAttributesTemp[3] == 0) mVitality.Text = "";
            else mVitality.Text = CDATA.cAttributesTemp[3] + "";
            if (CDATA.cAttributesTemp[4] == 0) mCharisma.Text = "";
            else mCharisma.Text = CDATA.cAttributesTemp[4] + "";
            if (CDATA.cAttributesTemp[5] == 0) mWillpower.Text = "";
            else mWillpower.Text = CDATA.cAttributesTemp[5] + "";

            cNotes.Text = CDATA.cNotes;

            cMentalStrain.Text = CDATA.cMentalStrain + "";
            cPhysicalStrain.Text = CDATA.cPhysicalStrain + "";
            cSpiritualStrain.Text = CDATA.cSpiritualStrain + "";

            cInitiative.Text = CDATA.cInitiative + "";
            cMementoMori.Text = CDATA.cMementoMori + "";
            cHumanity.Text = CDATA.cHumanity + "";

            cOverFocus.Text = CDATA.cOverFocus + "";
            cOverHealth.Text = CDATA.cOverHealth + "";
            cOverSanity.Text = CDATA.cOverSanity + "";
        }

        // On Load
        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            writeDATA();
            this.ActiveControl = cName;

            // Load Archetype Image
            reloadArch();

            // Load Title Image
            System.Reflection.Assembly myAssembly2 = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream2 = myAssembly2.GetManifestResourceStream("OrpheusManager.OrpheusTitle.png");
            Bitmap image2 = new Bitmap(myStream2);
            titlePic.Image = image2;

            // Load Divider Image
            System.Reflection.Assembly myAssembly3 = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream3 = myAssembly3.GetManifestResourceStream("OrpheusManager.divider.png");
            Bitmap image3 = new Bitmap(myStream3);
            divider1.Image = image3;
            divider2.Image = image3;

            writeDATA2();
        }

        private void reloadArch()
        {
            System.Reflection.Assembly myAssemblyHermetic = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamHermetic = myAssemblyHermetic.GetManifestResourceStream("OrpheusManager.archetypeHermetic.png");
            Bitmap imageHermetic = new Bitmap(myStreamHermetic);

            System.Reflection.Assembly myAssemblyWitch = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamWitch = myAssemblyWitch.GetManifestResourceStream("OrpheusManager.archetypeWitch.png");
            Bitmap imageWitch = new Bitmap(myStreamWitch);

            System.Reflection.Assembly myAssemblyPsychic = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamPsychic = myAssemblyPsychic.GetManifestResourceStream("OrpheusManager.archetypePsychic.png");
            Bitmap imagePsychic = new Bitmap(myStreamPsychic);

            System.Reflection.Assembly myAssemblyWeapon = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamWeapon = myAssemblyWeapon.GetManifestResourceStream("OrpheusManager.archetypeWeapon.png");
            Bitmap imageWeapon = new Bitmap(myStreamWeapon);

            System.Reflection.Assembly myAssemblyOccultist = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamOccultist = myAssemblyOccultist.GetManifestResourceStream("OrpheusManager.archetypeOccultist.png");
            Bitmap imageOccultist = new Bitmap(myStreamOccultist);

            System.Reflection.Assembly myAssemblyCyborg = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamCyborg = myAssemblyCyborg.GetManifestResourceStream("OrpheusManager.archetypeCyborg.png");
            Bitmap imageCyborg = new Bitmap(myStreamCyborg);

            System.Reflection.Assembly myAssemblyTelekinetic = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamTelekinetic = myAssemblyTelekinetic.GetManifestResourceStream("OrpheusManager.archetypeTelekinetic.png");
            Bitmap imageTelekinetic = new Bitmap(myStreamTelekinetic);

            System.Reflection.Assembly myAssemblyWendigo = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamWendigo = myAssemblyWendigo.GetManifestResourceStream("OrpheusManager.archetypeWendigo.png");
            Bitmap imageWendigo = new Bitmap(myStreamWendigo);

            System.Reflection.Assembly myAssemblyWerewolf = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamWerewolf = myAssemblyWerewolf.GetManifestResourceStream("OrpheusManager.archetypeWerewolf.png");
            Bitmap imageWerewolf = new Bitmap(myStreamWerewolf);

            System.Reflection.Assembly myAssemblyTrueFaith = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamTrueFaith = myAssemblyTrueFaith.GetManifestResourceStream("OrpheusManager.archetypeTrueFaith.png");
            Bitmap imageTrueFaith = new Bitmap(myStreamTrueFaith);

            System.Reflection.Assembly myAssemblyMedium = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamMedium = myAssemblyMedium.GetManifestResourceStream("OrpheusManager.archetypeMedium.png");
            Bitmap imageMedium = new Bitmap(myStreamMedium);

            System.Reflection.Assembly myAssemblySoldier = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStreamSoldier = myAssemblySoldier.GetManifestResourceStream("OrpheusManager.archetypeSoldier.png");
            Bitmap imageSoldier = new Bitmap(myStreamSoldier);

            if (CDATA.cArch1 == "Hermetic Magician") archetypePic.Image = imageHermetic;
            else if (CDATA.cArch1 == "Witch") archetypePic.Image = imageWitch;
            else if (CDATA.cArch1 == "Psychic") archetypePic.Image = imagePsychic;
            else if (CDATA.cArch1 == "Weapon Bearer") archetypePic.Image = imageWeapon;
            else if (CDATA.cArch1 == "Occultist") archetypePic.Image = imageOccultist;
            else if (CDATA.cArch1 == "Cyborg") archetypePic.Image = imageCyborg;
            else if (CDATA.cArch1 == "Wendigo") archetypePic.Image = imageWendigo;
            else if (CDATA.cArch1 == "Telekinetic") archetypePic.Image = imageTelekinetic;
            else if (CDATA.cArch1 == "Werewolf") archetypePic.Image = imageWerewolf;
            else if (CDATA.cArch1 == "True Faith") archetypePic.Image = imageTrueFaith;
            else if (CDATA.cArch1 == "Medium") archetypePic.Image = imageMedium;
            else if (CDATA.cArch1 == "Soldier") archetypePic.Image = imageSoldier;
            else archetypePic.Image = imageWitch;
        }

        // Modifier Boxes
        private void mPerception_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mPerception.Text, out temp))
            {
                CDATA.cAttributesTemp[0] = temp;
                writeDATA();
            }
            else if(mPerception.Text == "")
            {
                CDATA.cAttributesTemp[0] = 0;
                writeDATA();
            }
        }

        private void mCognition_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mCognition.Text, out temp))
            {
                CDATA.cAttributesTemp[1] = temp;
                writeDATA();
            }
            else if (mCognition.Text == "")
            {
                CDATA.cAttributesTemp[1] = 0;
                writeDATA();
            }
        }

        private void mDexterity_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mDexterity.Text, out temp))
            {
                CDATA.cAttributesTemp[2] = temp;
                writeDATA();
            }
            else if (mDexterity.Text == "")
            {
                CDATA.cAttributesTemp[2] = 0;
                writeDATA();
            }
        }

        private void mVitality_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mVitality.Text, out temp))
            {
                CDATA.cAttributesTemp[3] = temp;
                writeDATA();
            }
            else if (mVitality.Text == "")
            {
                CDATA.cAttributesTemp[3] = 0;
                writeDATA();
            }
        }

        private void mCharisma_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mCharisma.Text, out temp))
            {
                CDATA.cAttributesTemp[4] = temp;
                writeDATA();
            }
            else if (mCharisma.Text == "")
            {
                CDATA.cAttributesTemp[4] = 0;
                writeDATA();
            }
        }

        private void mWillpower_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(mWillpower.Text, out temp))
            {
                CDATA.cAttributesTemp[5] = temp;
                writeDATA();
            }
            else if (mWillpower.Text == "")
            {
                CDATA.cAttributesTemp[5] = 0;
                writeDATA();
            }
        }

        // Menu Bar
        private void characterNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form eCharName = new editCharacterName();
            eCharName.ShowDialog();
            // Update Character Name
            writeDATA();
        }

        private void addSkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form aSkill = new addSkillForm();
            aSkill.ShowDialog();
            // Update Character
            writeDATA();
        }

        private void newCharacter_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form nChar = new newCharacter();
            nChar.ShowDialog();

            // Update Character
            mPerception.Text = "";
            mCognition.Text = "";
            mDexterity.Text = "";
            mVitality.Text = "";
            mCharisma.Text = "";
            mWillpower.Text = "";
            for (int i = 0; i < 6; i++) { CDATA.cAttributesTemp[i] = 0; }
            DDATA.deriveDATA();
            CDATA.cMentalStrain = DDATA.dMentalStrainMax;
            CDATA.cPhysicalStrain = DDATA.dPhysicalStrainMax;
            CDATA.cSpiritualStrain = DDATA.dSpiritualStrainMax;
            CDATA.cInitiative = 0;
            CDATA.cMementoMori = 0;
            CDATA.cHumanity = CDATA.cHumanityMax;
            CDATA.cHumanityMax = 100;
            CDATA.cOverFocus = 0;
            CDATA.cOverHealth = 0;
            CDATA.cOverSanity = 0;
            writeDATA();
            writeDATA2();

            m1m1.Checked = false;
            m1m2.Checked = false;
            m1m3.Checked = false;
            m1m4.Checked = false;
            m1m5.Checked = false;
            m1m6.Checked = false;
            m2m1.Checked = false;
            m2m2.Checked = false;
            m2m3.Checked = false;
            m2m4.Checked = false;
            m2m5.Checked = false;
            m2m6.Checked = false;
            m3m1.Checked = false;
            m3m2.Checked = false;
            m3m3.Checked = false;
            m3m4.Checked = false;
            m3m5.Checked = false;
            m3m6.Checked = false;

            FW1.Checked = false;
            FW2.Checked = false;
            FW3.Checked = false;
            FW4.Checked = false;
            FW5.Checked = false;
            FW6.Checked = false;
            FW7.Checked = false;
            FW8.Checked = false;
            FW9.Checked = false;
            FW10.Checked = false;

            HW1.Checked = false;
            HW2.Checked = false;
            HW3.Checked = false;
            HW4.Checked = false;
            HW5.Checked = false;
            HW6.Checked = false;
            HW7.Checked = false;
            HW8.Checked = false;
            HW9.Checked = false;
            HW10.Checked = false;

            SW1.Checked = false;
            SW2.Checked = false;
            SW3.Checked = false;
            SW4.Checked = false;
            SW5.Checked = false;
            SW6.Checked = false;
            SW7.Checked = false;
            SW8.Checked = false;
            SW9.Checked = false;
            SW10.Checked = false;

            // Clear Skills/Abilities
            clearSkillsToolStripMenuItem_Click(this, System.EventArgs.Empty);
            clearAbilitiesToolStripMenuItem_Click(this, System.EventArgs.Empty);

            // Load Archetype Image
            reloadArch();

            // Clear Notes
            cNotes.Text = "";
        }

        private void clearSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 22; i++)
            {
                CDATA.cSkillName[i] = " ";
                CDATA.cSkillRank[i] = " ";
                CDATA.cCkillName[i] = " ";
                CDATA.cCkillRank[i] = " ";
            }
            writeDATA();
        }

        private void addAbilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Dialog Box
            Form aAbility = new addAbilityForm();
            aAbility.ShowDialog();
            // Update Character
            writeDATA();
        }

        private void clearAbilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                CDATA.cAbilityName[i] = " ";
                CDATA.cAbilityRank[i] = " ";
            }
            writeDATA();
        }

        private void maxHumanityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form eHumanity = new maxHumanity();
            eHumanity.ShowDialog();
            writeDATA();
            writeDATA2();
        }

        private void manageSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mSkills = new ManageSkills();
            mSkills.Show();
        }

        private void manageAbilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mAbilities = new ManageAbilities();
            mAbilities.Show();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDATA.cNotes = cNotes.Text;
            Int32.TryParse(cMentalStrain.Text, out CDATA.cMentalStrain);
            Int32.TryParse(cPhysicalStrain.Text, out CDATA.cPhysicalStrain);
            Int32.TryParse(cSpiritualStrain.Text, out CDATA.cSpiritualStrain);
            Int32.TryParse(cInitiative.Text, out CDATA.cInitiative);
            Int32.TryParse(cMementoMori.Text, out CDATA.cMementoMori);
            Int32.TryParse(cHumanity.Text, out CDATA.cHumanity);
            Int32.TryParse(cOverFocus.Text, out CDATA.cOverFocus);
            Int32.TryParse(cOverHealth.Text, out CDATA.cOverHealth);
            Int32.TryParse(cOverSanity.Text, out CDATA.cOverSanity);

            if (m1m1.Checked == true) CDATA.cMot1Box[0] = 1; else CDATA.cMot1Box[0] = 0;
            if (m1m2.Checked == true) CDATA.cMot1Box[1] = 1; else CDATA.cMot1Box[1] = 0;
            if (m1m3.Checked == true) CDATA.cMot1Box[2] = 1; else CDATA.cMot1Box[2] = 0;
            if (m1m4.Checked == true) CDATA.cMot1Box[3] = 1; else CDATA.cMot1Box[3] = 0;
            if (m1m5.Checked == true) CDATA.cMot1Box[4] = 1; else CDATA.cMot1Box[4] = 0;
            if (m1m6.Checked == true) CDATA.cMot1Box[5] = 1; else CDATA.cMot1Box[5] = 0;

            if (m2m1.Checked == true) CDATA.cMot2Box[0] = 1; else CDATA.cMot2Box[0] = 0;
            if (m2m2.Checked == true) CDATA.cMot2Box[1] = 1; else CDATA.cMot2Box[1] = 0;
            if (m2m3.Checked == true) CDATA.cMot2Box[2] = 1; else CDATA.cMot2Box[2] = 0;
            if (m2m4.Checked == true) CDATA.cMot2Box[3] = 1; else CDATA.cMot2Box[3] = 0;
            if (m2m5.Checked == true) CDATA.cMot2Box[4] = 1; else CDATA.cMot2Box[4] = 0;
            if (m2m6.Checked == true) CDATA.cMot2Box[5] = 1; else CDATA.cMot2Box[5] = 0;

            if (m3m1.Checked == true) CDATA.cMot3Box[0] = 1; else CDATA.cMot3Box[0] = 0;
            if (m3m2.Checked == true) CDATA.cMot3Box[1] = 1; else CDATA.cMot3Box[1] = 0;
            if (m3m3.Checked == true) CDATA.cMot3Box[2] = 1; else CDATA.cMot3Box[2] = 0;
            if (m3m4.Checked == true) CDATA.cMot3Box[3] = 1; else CDATA.cMot3Box[3] = 0;
            if (m3m5.Checked == true) CDATA.cMot3Box[4] = 1; else CDATA.cMot3Box[4] = 0;
            if (m3m6.Checked == true) CDATA.cMot3Box[5] = 1; else CDATA.cMot3Box[5] = 0;

            if (FW1.Checked == true) CDATA.cFocusWounds[0] = 1; else CDATA.cFocusWounds[0] = 0;
            if (FW2.Checked == true) CDATA.cFocusWounds[1] = 1; else CDATA.cFocusWounds[1] = 0;
            if (FW3.Checked == true) CDATA.cFocusWounds[2] = 1; else CDATA.cFocusWounds[2] = 0;
            if (FW4.Checked == true) CDATA.cFocusWounds[3] = 1; else CDATA.cFocusWounds[3] = 0;
            if (FW5.Checked == true) CDATA.cFocusWounds[4] = 1; else CDATA.cFocusWounds[4] = 0;
            if (FW6.Checked == true) CDATA.cFocusWounds[5] = 1; else CDATA.cFocusWounds[5] = 0;
            if (FW7.Checked == true) CDATA.cFocusWounds[6] = 1; else CDATA.cFocusWounds[6] = 0;
            if (FW8.Checked == true) CDATA.cFocusWounds[7] = 1; else CDATA.cFocusWounds[7] = 0;
            if (FW9.Checked == true) CDATA.cFocusWounds[8] = 1; else CDATA.cFocusWounds[8] = 0;
            if (FW10.Checked == true) CDATA.cFocusWounds[9] = 1; else CDATA.cFocusWounds[9] = 0;

            if (HW1.Checked == true) CDATA.cHealthWounds[0] = 1; else CDATA.cHealthWounds[0] = 0;
            if (HW2.Checked == true) CDATA.cHealthWounds[1] = 1; else CDATA.cHealthWounds[1] = 0;
            if (HW3.Checked == true) CDATA.cHealthWounds[2] = 1; else CDATA.cHealthWounds[2] = 0;
            if (HW4.Checked == true) CDATA.cHealthWounds[3] = 1; else CDATA.cHealthWounds[3] = 0;
            if (HW5.Checked == true) CDATA.cHealthWounds[4] = 1; else CDATA.cHealthWounds[4] = 0;
            if (HW6.Checked == true) CDATA.cHealthWounds[5] = 1; else CDATA.cHealthWounds[5] = 0;
            if (HW7.Checked == true) CDATA.cHealthWounds[6] = 1; else CDATA.cHealthWounds[6] = 0;
            if (HW8.Checked == true) CDATA.cHealthWounds[7] = 1; else CDATA.cHealthWounds[7] = 0;
            if (HW9.Checked == true) CDATA.cHealthWounds[8] = 1; else CDATA.cHealthWounds[8] = 0;
            if (HW10.Checked == true) CDATA.cHealthWounds[9] = 1; else CDATA.cHealthWounds[9] = 0;

            if (SW1.Checked == true) CDATA.cSanityWounds[0] = 1; else CDATA.cSanityWounds[0] = 0;
            if (SW2.Checked == true) CDATA.cSanityWounds[1] = 1; else CDATA.cSanityWounds[1] = 0;
            if (SW3.Checked == true) CDATA.cSanityWounds[2] = 1; else CDATA.cSanityWounds[2] = 0;
            if (SW4.Checked == true) CDATA.cSanityWounds[3] = 1; else CDATA.cSanityWounds[3] = 0;
            if (SW5.Checked == true) CDATA.cSanityWounds[4] = 1; else CDATA.cSanityWounds[4] = 0;
            if (SW6.Checked == true) CDATA.cSanityWounds[5] = 1; else CDATA.cSanityWounds[5] = 0;
            if (SW7.Checked == true) CDATA.cSanityWounds[6] = 1; else CDATA.cSanityWounds[6] = 0;
            if (SW8.Checked == true) CDATA.cSanityWounds[7] = 1; else CDATA.cSanityWounds[7] = 0;
            if (SW9.Checked == true) CDATA.cSanityWounds[8] = 1; else CDATA.cSanityWounds[8] = 0;
            if (FW10.Checked == true) CDATA.cSanityWounds[9] = 1; else CDATA.cSanityWounds[9] = 0;

            SaveFileDialog saver = new SaveFileDialog();
            saver.InitialDirectory = @"C:\";
            saver.Title = this.Text;
            saver.DefaultExt = "txt";
            saver.CheckPathExists = true;
            saver.FileName = CDATA.cName;

            if (saver.ShowDialog() == DialogResult.OK)
            {
                SDATA.generateFile(saver.FileName);
                SDATA.sFilepath = saver.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDATA.cNotes = cNotes.Text;
            Int32.TryParse(cMentalStrain.Text, out CDATA.cMentalStrain);
            Int32.TryParse(cPhysicalStrain.Text, out CDATA.cPhysicalStrain);
            Int32.TryParse(cSpiritualStrain.Text, out CDATA.cSpiritualStrain);
            Int32.TryParse(cInitiative.Text, out CDATA.cInitiative);
            Int32.TryParse(cMementoMori.Text, out CDATA.cMementoMori);
            Int32.TryParse(cHumanity.Text, out CDATA.cHumanity);
            Int32.TryParse(cOverFocus.Text, out CDATA.cOverFocus);
            Int32.TryParse(cOverHealth.Text, out CDATA.cOverHealth);
            Int32.TryParse(cOverSanity.Text, out CDATA.cOverSanity);

            if (m1m1.Checked == true) CDATA.cMot1Box[0] = 1; else CDATA.cMot1Box[0] = 0;
            if (m1m2.Checked == true) CDATA.cMot1Box[1] = 1; else CDATA.cMot1Box[1] = 0;
            if (m1m3.Checked == true) CDATA.cMot1Box[2] = 1; else CDATA.cMot1Box[2] = 0;
            if (m1m4.Checked == true) CDATA.cMot1Box[3] = 1; else CDATA.cMot1Box[3] = 0;
            if (m1m5.Checked == true) CDATA.cMot1Box[4] = 1; else CDATA.cMot1Box[4] = 0;
            if (m1m6.Checked == true) CDATA.cMot1Box[5] = 1; else CDATA.cMot1Box[5] = 0;

            if (m2m1.Checked == true) CDATA.cMot2Box[0] = 1; else CDATA.cMot2Box[0] = 0;
            if (m2m2.Checked == true) CDATA.cMot2Box[1] = 1; else CDATA.cMot2Box[1] = 0;
            if (m2m3.Checked == true) CDATA.cMot2Box[2] = 1; else CDATA.cMot2Box[2] = 0;
            if (m2m4.Checked == true) CDATA.cMot2Box[3] = 1; else CDATA.cMot2Box[3] = 0;
            if (m2m5.Checked == true) CDATA.cMot2Box[4] = 1; else CDATA.cMot2Box[4] = 0;
            if (m2m6.Checked == true) CDATA.cMot2Box[5] = 1; else CDATA.cMot2Box[5] = 0;

            if (m3m1.Checked == true) CDATA.cMot3Box[0] = 1; else CDATA.cMot3Box[0] = 0;
            if (m3m2.Checked == true) CDATA.cMot3Box[1] = 1; else CDATA.cMot3Box[1] = 0;
            if (m3m3.Checked == true) CDATA.cMot3Box[2] = 1; else CDATA.cMot3Box[2] = 0;
            if (m3m4.Checked == true) CDATA.cMot3Box[3] = 1; else CDATA.cMot3Box[3] = 0;
            if (m3m5.Checked == true) CDATA.cMot3Box[4] = 1; else CDATA.cMot3Box[4] = 0;
            if (m3m6.Checked == true) CDATA.cMot3Box[5] = 1; else CDATA.cMot3Box[5] = 0;

            if (FW1.Checked == true) CDATA.cFocusWounds[0] = 1; else CDATA.cFocusWounds[0] = 0;
            if (FW2.Checked == true) CDATA.cFocusWounds[1] = 1; else CDATA.cFocusWounds[1] = 0;
            if (FW3.Checked == true) CDATA.cFocusWounds[2] = 1; else CDATA.cFocusWounds[2] = 0;
            if (FW4.Checked == true) CDATA.cFocusWounds[3] = 1; else CDATA.cFocusWounds[3] = 0;
            if (FW5.Checked == true) CDATA.cFocusWounds[4] = 1; else CDATA.cFocusWounds[4] = 0;
            if (FW6.Checked == true) CDATA.cFocusWounds[5] = 1; else CDATA.cFocusWounds[5] = 0;
            if (FW7.Checked == true) CDATA.cFocusWounds[6] = 1; else CDATA.cFocusWounds[6] = 0;
            if (FW8.Checked == true) CDATA.cFocusWounds[7] = 1; else CDATA.cFocusWounds[7] = 0;
            if (FW9.Checked == true) CDATA.cFocusWounds[8] = 1; else CDATA.cFocusWounds[8] = 0;
            if (FW10.Checked == true) CDATA.cFocusWounds[9] = 1; else CDATA.cFocusWounds[9] = 0;

            if (HW1.Checked == true) CDATA.cHealthWounds[0] = 1; else CDATA.cHealthWounds[0] = 0;
            if (HW2.Checked == true) CDATA.cHealthWounds[1] = 1; else CDATA.cHealthWounds[1] = 0;
            if (HW3.Checked == true) CDATA.cHealthWounds[2] = 1; else CDATA.cHealthWounds[2] = 0;
            if (HW4.Checked == true) CDATA.cHealthWounds[3] = 1; else CDATA.cHealthWounds[3] = 0;
            if (HW5.Checked == true) CDATA.cHealthWounds[4] = 1; else CDATA.cHealthWounds[4] = 0;
            if (HW6.Checked == true) CDATA.cHealthWounds[5] = 1; else CDATA.cHealthWounds[5] = 0;
            if (HW7.Checked == true) CDATA.cHealthWounds[6] = 1; else CDATA.cHealthWounds[6] = 0;
            if (HW8.Checked == true) CDATA.cHealthWounds[7] = 1; else CDATA.cHealthWounds[7] = 0;
            if (HW9.Checked == true) CDATA.cHealthWounds[8] = 1; else CDATA.cHealthWounds[8] = 0;
            if (HW10.Checked == true) CDATA.cHealthWounds[9] = 1; else CDATA.cHealthWounds[9] = 0;

            if (SW1.Checked == true) CDATA.cSanityWounds[0] = 1; else CDATA.cSanityWounds[0] = 0;
            if (SW2.Checked == true) CDATA.cSanityWounds[1] = 1; else CDATA.cSanityWounds[1] = 0;
            if (SW3.Checked == true) CDATA.cSanityWounds[2] = 1; else CDATA.cSanityWounds[2] = 0;
            if (SW4.Checked == true) CDATA.cSanityWounds[3] = 1; else CDATA.cSanityWounds[3] = 0;
            if (SW5.Checked == true) CDATA.cSanityWounds[4] = 1; else CDATA.cSanityWounds[4] = 0;
            if (SW6.Checked == true) CDATA.cSanityWounds[5] = 1; else CDATA.cSanityWounds[5] = 0;
            if (SW7.Checked == true) CDATA.cSanityWounds[6] = 1; else CDATA.cSanityWounds[6] = 0;
            if (SW8.Checked == true) CDATA.cSanityWounds[7] = 1; else CDATA.cSanityWounds[7] = 0;
            if (SW9.Checked == true) CDATA.cSanityWounds[8] = 1; else CDATA.cSanityWounds[8] = 0;
            if (FW10.Checked == true) CDATA.cSanityWounds[9] = 1; else CDATA.cSanityWounds[9] = 0;

            if (SDATA.sFilepath != "") SDATA.generateFile(SDATA.sFilepath);
            else
            {
                SaveFileDialog saver = new SaveFileDialog();
                saver.InitialDirectory = @"C:\";
                saver.Title = this.Text;
                saver.DefaultExt = "txt";
                saver.CheckPathExists = true;
                saver.FileName = CDATA.cName;

                if (saver.ShowDialog() == DialogResult.OK)
                {
                    SDATA.generateFile(saver.FileName);
                    SDATA.sFilepath = saver.FileName;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opener = new OpenFileDialog();
            if (SDATA.sFilepath != "") opener.InitialDirectory = SDATA.sFilepath;
            else opener.InitialDirectory = @"C:\";
            opener.Title = "Orpheus Manager";

            if (opener.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(opener.FileName)) 
                {
                    SDATA.sFilepath = opener.FileName;
                    SDATA.sFullData = File.ReadAllText(opener.FileName);

                    CDATA.cName = SDATA.parseField("Character Name:\r\n");
                    Int32.TryParse(SDATA.parseField("Level:\r\n"), out CDATA.cLevel);
                    CDATA.cArch1 = SDATA.parseField("Archetype 1:\r\n");
                    CDATA.cArch2 = SDATA.parseField("Archetype 2:\r\n");
                    CDATA.cArch3 = SDATA.parseField("Archetype 3:\r\n");
                    CDATA.cBackground = SDATA.parseField("Background:\r\n");
                    CDATA.cMot1 = SDATA.parseField("Motivation 1:\r\n");
                    CDATA.cMot2 = SDATA.parseField("Motivation 2:\r\n");
                    CDATA.cMot3 = SDATA.parseField("Motivation 3:\r\n");
                    Int32.TryParse(SDATA.parseField("Mental Strain:\r\n"), out CDATA.cMentalStrain);
                    Int32.TryParse(SDATA.parseField("Physical Strain:\r\n"), out CDATA.cPhysicalStrain);
                    Int32.TryParse(SDATA.parseField("Spiritual Strain:\r\n"), out CDATA.cSpiritualStrain);
                    Int32.TryParse(SDATA.parseField("Initiative:\r\n"), out CDATA.cInitiative);
                    Int32.TryParse(SDATA.parseField("Memento Mori:\r\n"), out CDATA.cMementoMori);
                    Int32.TryParse(SDATA.parseField("Humanity:\r\n"), out CDATA.cHumanity);
                    Int32.TryParse(SDATA.parseField("Over Focus:\r\n"), out CDATA.cOverFocus);
                    Int32.TryParse(SDATA.parseField("Over Health:\r\n"), out CDATA.cOverHealth);
                    Int32.TryParse(SDATA.parseField("Over Sanity:\r\n"), out CDATA.cOverSanity);
                    CDATA.cNotes = SDATA.parseFieldEnd("Notes:\r\n");

                    string temp = SDATA.parseField("Attributes (PER, COG, DEX, VIT, CHAR, WILL):\r\n") + "\r\n";
                    Int32.TryParse(SDATA.parseLine(temp, 0), out CDATA.cAttributes[0]);
                    Int32.TryParse(SDATA.parseLine(temp, 1), out CDATA.cAttributes[1]);
                    Int32.TryParse(SDATA.parseLine(temp, 2), out CDATA.cAttributes[2]);
                    Int32.TryParse(SDATA.parseLine(temp, 3), out CDATA.cAttributes[3]);
                    Int32.TryParse(SDATA.parseLine(temp, 4), out CDATA.cAttributes[4]);
                    Int32.TryParse(SDATA.parseLine(temp, 5), out CDATA.cAttributes[5]);

                    temp = SDATA.parseField("Modifiers (PER, COG, DEX, VIT, CHAR, WILL):\r\n") + "\r\n";
                    Int32.TryParse(SDATA.parseLine(temp, 0), out CDATA.cAttributesTemp[0]);
                    Int32.TryParse(SDATA.parseLine(temp, 1), out CDATA.cAttributesTemp[1]);
                    Int32.TryParse(SDATA.parseLine(temp, 2), out CDATA.cAttributesTemp[2]);
                    Int32.TryParse(SDATA.parseLine(temp, 3), out CDATA.cAttributesTemp[3]);
                    Int32.TryParse(SDATA.parseLine(temp, 4), out CDATA.cAttributesTemp[4]);
                    Int32.TryParse(SDATA.parseLine(temp, 5), out CDATA.cAttributesTemp[5]);

                    temp = SDATA.parseField("Skills:\r\n") + "\r\n";
                    CDATA.cSkillName[0] = SDATA.parseLine(temp, 0);
                    CDATA.cSkillRank[0] = SDATA.parseLine(temp, 1);
                    CDATA.cSkillName[1] = SDATA.parseLine(temp, 2);
                    CDATA.cSkillRank[1] = SDATA.parseLine(temp, 3);
                    CDATA.cSkillName[2] = SDATA.parseLine(temp, 4);
                    CDATA.cSkillRank[2] = SDATA.parseLine(temp, 5);
                    CDATA.cSkillName[3] = SDATA.parseLine(temp, 6);
                    CDATA.cSkillRank[3] = SDATA.parseLine(temp, 7);
                    CDATA.cSkillName[4] = SDATA.parseLine(temp, 8);
                    CDATA.cSkillRank[4] = SDATA.parseLine(temp, 9);
                    CDATA.cSkillName[5] = SDATA.parseLine(temp, 10);
                    CDATA.cSkillRank[5] = SDATA.parseLine(temp, 11);
                    CDATA.cSkillName[6] = SDATA.parseLine(temp, 12);
                    CDATA.cSkillRank[6] = SDATA.parseLine(temp, 13);
                    CDATA.cSkillName[7] = SDATA.parseLine(temp, 14);
                    CDATA.cSkillRank[7] = SDATA.parseLine(temp, 15);
                    CDATA.cSkillName[8] = SDATA.parseLine(temp, 16);
                    CDATA.cSkillRank[8] = SDATA.parseLine(temp, 17);
                    CDATA.cSkillName[9] = SDATA.parseLine(temp, 18);
                    CDATA.cSkillRank[9] = SDATA.parseLine(temp, 19);
                    CDATA.cSkillName[10] = SDATA.parseLine(temp, 20);
                    CDATA.cSkillRank[10] = SDATA.parseLine(temp, 21);
                    CDATA.cSkillName[11] = SDATA.parseLine(temp, 22);
                    CDATA.cSkillRank[11] = SDATA.parseLine(temp, 23);
                    CDATA.cSkillName[12] = SDATA.parseLine(temp, 24);
                    CDATA.cSkillRank[12] = SDATA.parseLine(temp, 25);
                    CDATA.cSkillName[13] = SDATA.parseLine(temp, 26);
                    CDATA.cSkillRank[13] = SDATA.parseLine(temp, 27);
                    CDATA.cSkillName[14] = SDATA.parseLine(temp, 28);
                    CDATA.cSkillRank[14] = SDATA.parseLine(temp, 29);
                    CDATA.cSkillName[15] = SDATA.parseLine(temp, 30);
                    CDATA.cSkillRank[15] = SDATA.parseLine(temp, 31);
                    CDATA.cSkillName[16] = SDATA.parseLine(temp, 32);
                    CDATA.cSkillRank[16] = SDATA.parseLine(temp, 33);
                    CDATA.cSkillName[17] = SDATA.parseLine(temp, 34);
                    CDATA.cSkillRank[17] = SDATA.parseLine(temp, 35);
                    CDATA.cSkillName[18] = SDATA.parseLine(temp, 36);
                    CDATA.cSkillRank[18] = SDATA.parseLine(temp, 37);
                    CDATA.cSkillName[19] = SDATA.parseLine(temp, 38);
                    CDATA.cSkillRank[19] = SDATA.parseLine(temp, 39);
                    CDATA.cSkillName[20] = SDATA.parseLine(temp, 40);
                    CDATA.cSkillRank[20] = SDATA.parseLine(temp, 41);
                    CDATA.cSkillName[21] = SDATA.parseLine(temp, 42);
                    CDATA.cSkillRank[21] = SDATA.parseLine(temp, 43);

                    temp = SDATA.parseField("Combat Skills:\r\n") + "\r\n";
                    CDATA.cCkillName[0] = SDATA.parseLine(temp, 0);
                    CDATA.cCkillRank[0] = SDATA.parseLine(temp, 1);
                    CDATA.cCkillName[1] = SDATA.parseLine(temp, 2);
                    CDATA.cCkillRank[1] = SDATA.parseLine(temp, 3);
                    CDATA.cCkillName[2] = SDATA.parseLine(temp, 4);
                    CDATA.cCkillRank[2] = SDATA.parseLine(temp, 5);
                    CDATA.cCkillName[3] = SDATA.parseLine(temp, 6);
                    CDATA.cCkillRank[3] = SDATA.parseLine(temp, 7);
                    CDATA.cCkillName[4] = SDATA.parseLine(temp, 8);
                    CDATA.cCkillRank[4] = SDATA.parseLine(temp, 9);
                    CDATA.cCkillName[5] = SDATA.parseLine(temp, 10);
                    CDATA.cCkillRank[5] = SDATA.parseLine(temp, 11);
                    CDATA.cCkillName[6] = SDATA.parseLine(temp, 12);
                    CDATA.cCkillRank[6] = SDATA.parseLine(temp, 13);
                    CDATA.cCkillName[7] = SDATA.parseLine(temp, 14);
                    CDATA.cCkillRank[7] = SDATA.parseLine(temp, 15);
                    CDATA.cCkillName[8] = SDATA.parseLine(temp, 16);
                    CDATA.cCkillRank[8] = SDATA.parseLine(temp, 17);
                    CDATA.cCkillName[9] = SDATA.parseLine(temp, 18);
                    CDATA.cCkillRank[9] = SDATA.parseLine(temp, 19);
                    CDATA.cCkillName[10] = SDATA.parseLine(temp, 20);
                    CDATA.cCkillRank[10] = SDATA.parseLine(temp, 21);
                    CDATA.cCkillName[11] = SDATA.parseLine(temp, 22);
                    CDATA.cCkillRank[11] = SDATA.parseLine(temp, 23);
                    CDATA.cCkillName[12] = SDATA.parseLine(temp, 24);
                    CDATA.cCkillRank[12] = SDATA.parseLine(temp, 25);
                    CDATA.cCkillName[13] = SDATA.parseLine(temp, 26);
                    CDATA.cCkillRank[13] = SDATA.parseLine(temp, 27);
                    CDATA.cCkillName[14] = SDATA.parseLine(temp, 28);
                    CDATA.cCkillRank[14] = SDATA.parseLine(temp, 29);
                    CDATA.cCkillName[15] = SDATA.parseLine(temp, 30);
                    CDATA.cCkillRank[15] = SDATA.parseLine(temp, 31);
                    CDATA.cCkillName[16] = SDATA.parseLine(temp, 32);
                    CDATA.cCkillRank[16] = SDATA.parseLine(temp, 33);
                    CDATA.cCkillName[17] = SDATA.parseLine(temp, 34);
                    CDATA.cCkillRank[17] = SDATA.parseLine(temp, 35);
                    CDATA.cCkillName[18] = SDATA.parseLine(temp, 36);
                    CDATA.cCkillRank[18] = SDATA.parseLine(temp, 37);
                    CDATA.cCkillName[19] = SDATA.parseLine(temp, 38);
                    CDATA.cCkillRank[19] = SDATA.parseLine(temp, 39);
                    CDATA.cCkillName[20] = SDATA.parseLine(temp, 40);
                    CDATA.cCkillRank[20] = SDATA.parseLine(temp, 41);
                    CDATA.cCkillName[21] = SDATA.parseLine(temp, 42);
                    CDATA.cCkillRank[21] = SDATA.parseLine(temp, 43);

                    temp = SDATA.parseField("Abilities:\r\n") + "\r\n";
                    CDATA.cAbilityName[0] = SDATA.parseLine(temp, 0);
                    CDATA.cAbilityRank[0] = SDATA.parseLine(temp, 1);
                    CDATA.cAbilityName[1] = SDATA.parseLine(temp, 2);
                    CDATA.cAbilityRank[1] = SDATA.parseLine(temp, 3);
                    CDATA.cAbilityName[2] = SDATA.parseLine(temp, 4);
                    CDATA.cAbilityRank[2] = SDATA.parseLine(temp, 5);
                    CDATA.cAbilityName[3] = SDATA.parseLine(temp, 6);
                    CDATA.cAbilityRank[3] = SDATA.parseLine(temp, 7);
                    CDATA.cAbilityName[4] = SDATA.parseLine(temp, 8);
                    CDATA.cAbilityRank[4] = SDATA.parseLine(temp, 9);
                    CDATA.cAbilityName[5] = SDATA.parseLine(temp, 10);
                    CDATA.cAbilityRank[5] = SDATA.parseLine(temp, 11);
                    CDATA.cAbilityName[6] = SDATA.parseLine(temp, 12);
                    CDATA.cAbilityRank[6] = SDATA.parseLine(temp, 13);
                    CDATA.cAbilityName[7] = SDATA.parseLine(temp, 14);
                    CDATA.cAbilityRank[7] = SDATA.parseLine(temp, 15);
                    CDATA.cAbilityName[8] = SDATA.parseLine(temp, 16);
                    CDATA.cAbilityRank[8] = SDATA.parseLine(temp, 17);
                    CDATA.cAbilityName[9] = SDATA.parseLine(temp, 18);
                    CDATA.cAbilityRank[9] = SDATA.parseLine(temp, 19);
                    CDATA.cAbilityName[10] = SDATA.parseLine(temp, 20);
                    CDATA.cAbilityRank[10] = SDATA.parseLine(temp, 21);
                    CDATA.cAbilityName[11] = SDATA.parseLine(temp, 22);
                    CDATA.cAbilityRank[11] = SDATA.parseLine(temp, 23);

                    temp = SDATA.parseField("Motivation 1 Boxes:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") m1m1.Checked = true; else m1m1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") m1m2.Checked = true; else m1m2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") m1m3.Checked = true; else m1m3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") m1m4.Checked = true; else m1m4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") m1m5.Checked = true; else m1m5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") m1m6.Checked = true; else m1m6.Checked = false;

                    temp = SDATA.parseField("Motivation 2 Boxes:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") m2m1.Checked = true; else m2m1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") m2m2.Checked = true; else m2m2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") m2m3.Checked = true; else m2m3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") m2m4.Checked = true; else m2m4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") m2m5.Checked = true; else m2m5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") m2m6.Checked = true; else m2m6.Checked = false;

                    temp = SDATA.parseField("Motivation 3 Boxes:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") m3m1.Checked = true; else m3m1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") m3m2.Checked = true; else m3m2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") m3m3.Checked = true; else m3m3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") m3m4.Checked = true; else m3m4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") m3m5.Checked = true; else m3m5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") m3m6.Checked = true; else m3m6.Checked = false;

                    temp = SDATA.parseField("Focus Damage:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") FW1.Checked = true; else FW1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") FW2.Checked = true; else FW2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") FW3.Checked = true; else FW3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") FW4.Checked = true; else FW4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") FW5.Checked = true; else FW5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") FW6.Checked = true; else FW6.Checked = false;
                    if (SDATA.parseLine(temp, 6) == "1") FW7.Checked = true; else FW7.Checked = false;
                    if (SDATA.parseLine(temp, 7) == "1") FW8.Checked = true; else FW8.Checked = false;
                    if (SDATA.parseLine(temp, 8) == "1") FW9.Checked = true; else FW9.Checked = false;
                    if (SDATA.parseLine(temp, 9) == "1") FW10.Checked = true; else FW10.Checked = false;

                    temp = SDATA.parseField("Health Damage:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") HW1.Checked = true; else HW1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") HW2.Checked = true; else HW2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") HW3.Checked = true; else HW3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") HW4.Checked = true; else HW4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") HW5.Checked = true; else HW5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") HW6.Checked = true; else HW6.Checked = false;
                    if (SDATA.parseLine(temp, 6) == "1") HW7.Checked = true; else HW7.Checked = false;
                    if (SDATA.parseLine(temp, 7) == "1") HW8.Checked = true; else HW8.Checked = false;
                    if (SDATA.parseLine(temp, 8) == "1") HW9.Checked = true; else HW9.Checked = false;
                    if (SDATA.parseLine(temp, 9) == "1") HW10.Checked = true; else HW10.Checked = false;

                    temp = SDATA.parseField("Sanity Damage:\r\n") + "\r\n";
                    if (SDATA.parseLine(temp, 0) == "1") SW1.Checked = true; else SW1.Checked = false;
                    if (SDATA.parseLine(temp, 1) == "1") SW2.Checked = true; else SW2.Checked = false;
                    if (SDATA.parseLine(temp, 2) == "1") SW3.Checked = true; else SW3.Checked = false;
                    if (SDATA.parseLine(temp, 3) == "1") SW4.Checked = true; else SW4.Checked = false;
                    if (SDATA.parseLine(temp, 4) == "1") SW5.Checked = true; else SW5.Checked = false;
                    if (SDATA.parseLine(temp, 5) == "1") SW6.Checked = true; else SW6.Checked = false;
                    if (SDATA.parseLine(temp, 6) == "1") SW7.Checked = true; else SW7.Checked = false;
                    if (SDATA.parseLine(temp, 7) == "1") SW8.Checked = true; else SW8.Checked = false;
                    if (SDATA.parseLine(temp, 8) == "1") SW9.Checked = true; else SW9.Checked = false;
                    if (SDATA.parseLine(temp, 9) == "1") SW10.Checked = true; else SW10.Checked = false;

                    reloadArch();
                    writeDATA();
                    writeDATA2();
                }
            }
        }
    }
}