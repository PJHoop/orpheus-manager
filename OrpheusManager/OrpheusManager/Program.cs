﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.IO;
using System.Text;

namespace OrpheusManager
{
    public static class CDATA
    {
        public static string version = "v1.0";
        public static string gameVersion = "v2.1.2";
        public static string cName = "Rodrigo Ledesma";
        public static int cLevel = 0;
        public static string cArch1 = "Weapon Bearer";
        public static string cArch2 = "Wendigo";
        public static string cArch3 = "";
        public static string cBackground = "Criminal";
        public static int[] cAttributes = { 2, 1, 4, 2, 3, 3 };         // PER, COG, DEX, VIT, CHAR, WILL
        public static int[] cAttributesTemp = { 0, 0, 0, 0, 0, 0 };
        public static string cMot1 = "Uniting Force";
        public static string cMot2 = "Lady Killer";
        public static string cMot3 = "Death Wish";
        public static string cMot4 = " ";
        public static string cMot5 = " ";
        public static string cMot6 = " ";
        public static string cMot7 = " ";
        public static string cNotes = "";
        public static int cMentalStrain = 5;
        public static int cPhysicalStrain = 10;
        public static int cSpiritualStrain = 12;
        public static int cInitiative = 0;
        public static int cMementoMori = 0;
        public static int cHumanity = 100;
        public static int cHumanityMax = 100;
        public static int cOverFocus = 0;
        public static int cOverHealth = 0;
        public static int cOverSanity = 0;
        public static int cInitialCsp = 0;
        public static int cInitialNcsp = 0;
        public static int cAcc1 = 0;
        public static int cAcc2 = 0;
        public static int cAcc3 = 0;
        public static int cAcc4 = 0;

        public static string[] cSkillName = { "Intimidation", "Presence", "Athletics", "Deception", "Cont. (Underworld)", "Security", "Sleight of Hand", "Empathy", "Investigation", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", };
        public static string[] cSkillRank = { "V", "V", "III", "III", "II", "II", "I", "I", "I", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", };

        public static string[] cCkillName = { "Attack (Pistols)", "Stealth", "Stability", "Dodge", "Discipline", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", };
        public static string[] cCkillRank = { "V", "V", "III", "III", "I", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", };

        public static string[] cAbilityName = { "Inspiration", "Hungry Shadows", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static string[] cAbilityRank = { "II", "I", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public static int[] cAbilityMasteryA = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] cAbilityMasteryB = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] cAbilityOverload = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static int[] cMot1Box = { 0, 0, 0, 0, 0, 0 };
        public static int[] cMot2Box = { 0, 0, 0, 0, 0, 0 };
        public static int[] cMot3Box = { 0, 0, 0, 0, 0, 0 };
        public static int[] cMot4Box = { 0, 0, 0, 0, 0, 0 };
        public static int[] cMot5Box = { 0, 0, 0, 0, 0, 0 };
        public static int[] cMot6Box = { 0, 0, 0, 0, 0, 0 };
        public static int[] cMot7Box = { 0, 0, 0, 0, 0, 0 };

        public static int[] cFocusWounds = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] cHealthWounds = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] cSanityWounds = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static int cMaxMentStrain = 0;
        public static int cMaxPhysStrain = 0;
        public static int cMaxSpirStrain = 0;

        public static void addSkill()
        {
            bool full = false;
            int loc = 0;
            if (EDATA.eSkillType == 0)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (cSkillName[i] == " ") { loc = i; break; }
                    if (i == 19) full = true;
                }
                if (!full)
                {
                    cSkillName[loc] = EDATA.eSkillName;
                    cSkillRank[loc] = EDATA.eSkillRank;
                }
            }
            else if (EDATA.eSkillType == 1)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (cCkillName[i] == " ") { loc = i; break; }
                    if (i == 19) full = true;
                }
                if (!full)
                {
                    cCkillName[loc] = EDATA.eSkillName;
                    cCkillRank[loc] = EDATA.eSkillRank;
                }
            }
        }

        public static void addAbility()
        {
            bool full = false;
            int loc = 0;

            for (int i = 0; i < 12; i++)
            {
                if (cAbilityName[i] == " ") { loc = i; break; }
                if (i == 11) full = true;
            }
            if (!full)
            {
                cAbilityName[loc] = EDATA.eAbilityName;
                cAbilityRank[loc] = EDATA.eAbilityRank;
            }
        }
    }

    public static class DDATA
    {
        public static void deriveDATA()
        {
            DDATA.dMeleeAtt = ((CDATA.cAttributes[2] + CDATA.cAttributes[3]) / 2);
            DDATA.dRangedAtt = ((CDATA.cAttributes[2] + CDATA.cAttributes[0]) / 2);
            DDATA.dSpeed = ((CDATA.cAttributes[2] + CDATA.cAttributes[3]) / 2);

            DDATA.dMeleeAttTemp = (((CDATA.cAttributes[2] + CDATA.cAttributesTemp[2]) + (CDATA.cAttributes[3]) + CDATA.cAttributesTemp[3]) / 2) - ((CDATA.cAttributes[2] + CDATA.cAttributes[3]) / 2);
            DDATA.dRangedAttTemp = (((CDATA.cAttributes[2] + CDATA.cAttributesTemp[2]) + (CDATA.cAttributes[0] + CDATA.cAttributesTemp[0])) / 2) - ((CDATA.cAttributes[2] + CDATA.cAttributes[0]) / 2); ;
            DDATA.dSpeedTemp = (((CDATA.cAttributes[2] + CDATA.cAttributesTemp[2]) + (CDATA.cAttributes[3] + CDATA.cAttributesTemp[3])) / 2) - ((CDATA.cAttributes[2] + CDATA.cAttributes[3]) / 2);

            if (CDATA.cAttributes[1] >= 5) DDATA.dClarity = 2;
            else if (CDATA.cAttributes[1] >= 3) DDATA.dClarity = 1;
            else DDATA.dClarity = 0;

            if (CDATA.cAttributes[1] + CDATA.cAttributesTemp[1] >= 5) DDATA.dClarityTemp = 2 - DDATA.dClarity;
            else if (CDATA.cAttributes[1] + CDATA.cAttributesTemp[1] >= 3) DDATA.dClarityTemp = 1 - DDATA.dClarity;
            else DDATA.dClarityTemp = 0 - DDATA.dClarity;

            if (CDATA.cAttributes[3] >= 5) DDATA.dToughness = 2;
            else if (CDATA.cAttributes[3] >= 3) DDATA.dToughness = 1;
            else DDATA.dToughness = 0;

            if (CDATA.cAttributes[3] + CDATA.cAttributesTemp[3] >= 5) DDATA.dToughnessTemp = 2 - DDATA.dToughness;
            else if (CDATA.cAttributes[3] + CDATA.cAttributesTemp[3] >= 3) DDATA.dToughnessTemp = 1 - DDATA.dToughness;
            else DDATA.dToughnessTemp = 0 - DDATA.dToughness;

            if (CDATA.cAttributes[5] >= 5) DDATA.dForceOfWill = 2;
            else if (CDATA.cAttributes[5] >= 3) DDATA.dForceOfWill = 1;
            else DDATA.dForceOfWill = 0;

            if (CDATA.cAttributes[5] + CDATA.cAttributesTemp[5] >= 5) DDATA.dForceOfWillTemp = 2 - DDATA.dForceOfWill;
            else if (CDATA.cAttributes[5] + CDATA.cAttributesTemp[5] >= 3) DDATA.dForceOfWillTemp = 1 - DDATA.dForceOfWill;
            else DDATA.dForceOfWillTemp = 0 - DDATA.dForceOfWill;

            int tempx;
            int tempy;

            if (DDATA.dForceOfWill >= 1) tempx = 1;
            else tempx = 0;

            if (DDATA.dForceOfWill + DDATA.dForceOfWillTemp >= 1) tempy = 1;
            else tempy = 0;

            DDATA.dTactics = tempx + DDATA.dClarity;
            DDATA.dTacticsTemp = (tempy + (DDATA.dClarity + DDATA.dClarityTemp)) - DDATA.dTactics;

            int temp1;
            int temp2;
            int temp3;

            temp1 = CDATA.cAttributes[2] + CDATA.cAttributesTemp[2] + CDATA.cAttributes[5] + CDATA.cAttributesTemp[5] + dClarity;
            temp2 = CDATA.cAttributes[0] + CDATA.cAttributesTemp[0] + CDATA.cAttributes[5] + CDATA.cAttributesTemp[5] + dClarity;
            temp3 = CDATA.cAttributes[0] + CDATA.cAttributesTemp[0] + CDATA.cAttributes[2] + CDATA.cAttributesTemp[2] + dClarity;


            if (temp1 >= temp2 && temp1 >= temp3)
            {
                DDATA.dInitiative = CDATA.cAttributes[2] + CDATA.cAttributes[5] + dClarity;
                DDATA.dInitiativeTemp = CDATA.cAttributesTemp[2] + CDATA.cAttributesTemp[5];
            }
            else if (temp2 >= temp1 && temp2 >= temp3)
            {
                DDATA.dInitiative = CDATA.cAttributes[0] + CDATA.cAttributes[5] + dClarity;
                DDATA.dInitiativeTemp = CDATA.cAttributesTemp[0] + CDATA.cAttributesTemp[5];
            }
            else
            {
                DDATA.dInitiative = CDATA.cAttributes[0] + CDATA.cAttributes[2] + dClarity;
                DDATA.dInitiativeTemp = CDATA.cAttributesTemp[0] + CDATA.cAttributesTemp[2];
            }

            dMentalStrainMax = CDATA.cAttributes[0] + (3 * CDATA.cAttributes[1]);
            dPhysicalStrainMax = CDATA.cAttributes[2] + (3 * CDATA.cAttributes[3]);
            dSpiritualStrainMax = CDATA.cAttributes[4] + (3 * CDATA.cAttributes[5]);
        }

        public static int dMeleeAtt = 0;
        public static int dRangedAtt = 0;
        public static int dSpeed = 0;
        public static int dClarity = 0;
        public static int dToughness = 0;
        public static int dForceOfWill = 0;
        public static int dInitiative = 0;
        public static int dTactics = 0;
        public static int dMentalStrainMax = 0;
        public static int dPhysicalStrainMax = 0;
        public static int dSpiritualStrainMax = 0;

        public static int dMeleeAttTemp = 0;
        public static int dRangedAttTemp = 0;
        public static int dSpeedTemp = 0;
        public static int dClarityTemp = 0;
        public static int dToughnessTemp = 0;
        public static int dForceOfWillTemp = 0;
        public static int dInitiativeTemp = 0;
        public static int dTacticsTemp = 0;
    }

    public static class LDATA
    {
        public static int lAttributesCurrent = 0;
        public static int lAttributesMax = 0;

        public static int lCspCurrent = 0;
        public static int lCspMax = 0;

        public static int lNcspCurrent = 0;
        public static int lNcspMax = 0;

        public static int lAbilityRankCurrent = 0;
        public static int lAbilityRankMax = 0;

        public static int lAbilityMasteryCurrent = 0;
        public static int lAbilityMasteryMax = 0;

        public static int lAbilitySynthesisCurrent = 0;
        public static int lAbilitySynthesisMax = 0;

        public static int lAbilityOverloadCurrent = 0;
        public static int lAbilityOverloadMax = 0;

        public static int lMotivationsCurrent = 0;
        public static int lMotivationsMax = 0;

        public static int lAcclimationsCurrent = 0;
        public static int lAcclimationsMax = 0;

        public static int lStrainCurrent = 0;
        public static int lStrainMax = 0;

        public static void calculate()
        {
            lAttributesCurrent = lAttributesMax = 0;
            lCspCurrent = lCspMax = 0;
            lNcspCurrent = lNcspMax = 0;
            lAbilityRankCurrent = lAbilityRankMax = 0;
            lAbilityMasteryCurrent = lAbilityMasteryMax = 0;
            lAbilitySynthesisCurrent = lAbilitySynthesisMax = 0;
            lAbilityOverloadCurrent = lAbilityOverloadMax = 0;
            lMotivationsCurrent = lMotivationsMax = 0;
            lAcclimationsCurrent = lAcclimationsMax = 0;
            lStrainCurrent = lStrainMax = 0;

            for (int i = 0; i < 6; i++) { lAttributesCurrent += CDATA.cAttributes[i]; }
            for (int i = 0; i < 20; i++) { lCspCurrent += EDATA.numToWeightedInt(CDATA.cCkillRank[i]); }
            for (int i = 0; i < 20; i++) { lNcspCurrent += EDATA.numToWeightedInt(CDATA.cSkillRank[i]); }
            for (int i = 0; i < 12; i++) { lAbilityRankCurrent += EDATA.numToRealInt(CDATA.cAbilityRank[i]); }
            for (int i = 0; i < 12; i++) { lAbilityMasteryCurrent += CDATA.cAbilityMasteryA[i] + CDATA.cAbilityMasteryB[i]; }
            for (int i = 0; i < 12; i++) { if (CDATA.cAbilityMasteryA[i] == 1 && CDATA.cAbilityMasteryB[i] == 1) lAbilitySynthesisCurrent += 1; }
            for (int i = 0; i < 12; i++) { lAbilityOverloadCurrent += CDATA.cAbilityOverload[i]; }

            lMotivationsCurrent = 7;

            if (CDATA.cMot1 == "" || CDATA.cMot1 == " ") lMotivationsCurrent -= 1;
            if (CDATA.cMot2 == "" || CDATA.cMot2 == " ") lMotivationsCurrent -= 1;
            if (CDATA.cMot3 == "" || CDATA.cMot3 == " ") lMotivationsCurrent -= 1;
            if (CDATA.cMot4 == "" || CDATA.cMot4 == " ") lMotivationsCurrent -= 1;
            if (CDATA.cMot5 == "" || CDATA.cMot5 == " ") lMotivationsCurrent -= 1;
            if (CDATA.cMot6 == "" || CDATA.cMot6 == " ") lMotivationsCurrent -= 1;
            if (CDATA.cMot7 == "" || CDATA.cMot7 == " ") lMotivationsCurrent -= 1;

            if (CDATA.cAcc1 == 1) lAcclimationsCurrent++;
            if (CDATA.cAcc2 == 1) lAcclimationsCurrent++;
            if (CDATA.cAcc3 == 1) lAcclimationsCurrent++;
            if (CDATA.cAcc4 == 1) lAcclimationsCurrent++;

            lStrainCurrent = CDATA.cMaxMentStrain + CDATA.cMaxPhysStrain + CDATA.cMaxSpirStrain;

            switch (CDATA.cLevel)
            {
                case 0:
                    lAttributesMax = 15;
                    lCspMax = 0;
                    lNcspMax = 0;
                    lAbilityRankMax = 3;
                    lAbilityMasteryMax = 0;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 0;
                    lMotivationsMax = 3;
                    lAcclimationsMax = 0;
                    lStrainMax = 0;
                    break;
                case 1:
                    lAttributesMax = 15;
                    lCspMax = 1;
                    lNcspMax = 1;
                    lAbilityRankMax = 4;
                    lAbilityMasteryMax = 0;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 0;
                    lMotivationsMax = 3;
                    lAcclimationsMax = 0;
                    lStrainMax = 0;
                    break;
                case 2:
                    lAttributesMax = 15;
                    lCspMax = 2;
                    lNcspMax = 2;
                    lAbilityRankMax = 5;
                    lAbilityMasteryMax = 0;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 0;
                    lMotivationsMax = 3;
                    lAcclimationsMax = 0;
                    lStrainMax = 2;
                    break;
                case 3:
                    lAttributesMax = 15;
                    lCspMax = 3;
                    lNcspMax = 3;
                    lAbilityRankMax = 6;
                    lAbilityMasteryMax = 1;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 0;
                    lMotivationsMax = 3;
                    lAcclimationsMax = 0;
                    lStrainMax = 2;
                    break;
                case 4:
                    lAttributesMax = 16;
                    lCspMax = 5;
                    lNcspMax = 4;
                    lAbilityRankMax = 6;
                    lAbilityMasteryMax = 1;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 0;
                    lMotivationsMax = 3;
                    lAcclimationsMax = 0;
                    lStrainMax = 2;
                    break;
                case 5:
                    lAttributesMax = 16;
                    lCspMax = 6;
                    lNcspMax = 5;
                    lAbilityRankMax = 7;
                    lAbilityMasteryMax = 1;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 1;
                    lMotivationsMax = 4;
                    lAcclimationsMax = 1;
                    lStrainMax = 2;
                    break;
                case 6:
                    lAttributesMax = 16;
                    lCspMax = 7;
                    lNcspMax = 6;
                    lAbilityRankMax = 8;
                    lAbilityMasteryMax = 1;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 1;
                    lMotivationsMax = 4;
                    lAcclimationsMax = 1;
                    lStrainMax = 4;
                    break;
                case 7:
                    lAttributesMax = 16;
                    lCspMax = 8;
                    lNcspMax = 7;
                    lAbilityRankMax = 9;
                    lAbilityMasteryMax = 2;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 1;
                    lMotivationsMax = 4;
                    lAcclimationsMax = 1;
                    lStrainMax = 4;
                    break;
                case 8:
                    lAttributesMax = 17;
                    lCspMax = 10;
                    lNcspMax = 8;
                    lAbilityRankMax = 9;
                    lAbilityMasteryMax = 2;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 1;
                    lMotivationsMax = 4;
                    lAcclimationsMax = 1;
                    lStrainMax = 4;
                    break;
                case 9:
                    lAttributesMax = 17;
                    lCspMax = 11;
                    lNcspMax = 9;
                    lAbilityRankMax = 10;
                    lAbilityMasteryMax = 2;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 1;
                    lMotivationsMax = 4;
                    lAcclimationsMax = 1;
                    lStrainMax = 4;
                    break;
                case 10:
                    lAttributesMax = 17;
                    lCspMax = 12;
                    lNcspMax = 10;
                    lAbilityRankMax = 11;
                    lAbilityMasteryMax = 3;
                    lAbilitySynthesisMax = 1;
                    lAbilityOverloadMax = 2;
                    lMotivationsMax = 5;
                    lAcclimationsMax = 2;
                    lStrainMax = 6;
                    break;
                case 11:
                    lAttributesMax = 17;
                    lCspMax = 13;
                    lNcspMax = 11;
                    lAbilityRankMax = 12;
                    lAbilityMasteryMax = 4;
                    lAbilitySynthesisMax = 1;
                    lAbilityOverloadMax = 2;
                    lMotivationsMax = 5;
                    lAcclimationsMax = 2;
                    lStrainMax = 6;
                    break;
                case 12:
                    lAttributesMax = 18;
                    lCspMax = 15;
                    lNcspMax = 12;
                    lAbilityRankMax = 12;
                    lAbilityMasteryMax = 4;
                    lAbilitySynthesisMax = 1;
                    lAbilityOverloadMax = 2;
                    lMotivationsMax = 5;
                    lAcclimationsMax = 2;
                    lStrainMax = 6;
                    break;
                case 13:
                    lAttributesMax = 18;
                    lCspMax = 16;
                    lNcspMax = 13;
                    lAbilityRankMax = 13;
                    lAbilityMasteryMax = 4;
                    lAbilitySynthesisMax = 1;
                    lAbilityOverloadMax = 2;
                    lMotivationsMax = 5;
                    lAcclimationsMax = 2;
                    lStrainMax = 6;
                    break;
                case 14:
                    lAttributesMax = 18;
                    lCspMax = 17;
                    lNcspMax = 14;
                    lAbilityRankMax = 14;
                    lAbilityMasteryMax = 4;
                    lAbilitySynthesisMax = 1;
                    lAbilityOverloadMax = 2;
                    lMotivationsMax = 5;
                    lAcclimationsMax = 2;
                    lStrainMax = 8;
                    break;
                case 15:
                    lAttributesMax = 18;
                    lCspMax = 18;
                    lNcspMax = 15;
                    lAbilityRankMax = 15;
                    lAbilityMasteryMax = 5;
                    lAbilitySynthesisMax = 1;
                    lAbilityOverloadMax = 3;
                    lMotivationsMax = 6;
                    lAcclimationsMax = 3;
                    lStrainMax = 8;
                    break;
                case 16:
                    lAttributesMax = 19;
                    lCspMax = 20;
                    lNcspMax = 16;
                    lAbilityRankMax = 15;
                    lAbilityMasteryMax = 5;
                    lAbilitySynthesisMax = 1;
                    lAbilityOverloadMax = 3;
                    lMotivationsMax = 6;
                    lAcclimationsMax = 3;
                    lStrainMax = 8;
                    break;
                case 17:
                    lAttributesMax = 19;
                    lCspMax = 21;
                    lNcspMax = 17;
                    lAbilityRankMax = 16;
                    lAbilityMasteryMax = 5;
                    lAbilitySynthesisMax = 1;
                    lAbilityOverloadMax = 3;
                    lMotivationsMax = 6;
                    lAcclimationsMax = 3;
                    lStrainMax = 8;
                    break;
                case 18:
                    lAttributesMax = 19;
                    lCspMax = 22;
                    lNcspMax = 18;
                    lAbilityRankMax = 17;
                    lAbilityMasteryMax = 5;
                    lAbilitySynthesisMax = 1;
                    lAbilityOverloadMax = 3;
                    lMotivationsMax = 6;
                    lAcclimationsMax = 3;
                    lStrainMax = 10;
                    break;
                case 19:
                    lAttributesMax = 19;
                    lCspMax = 23;
                    lNcspMax = 19;
                    lAbilityRankMax = 18;
                    lAbilityMasteryMax = 6;
                    lAbilitySynthesisMax = 1;
                    lAbilityOverloadMax = 3;
                    lMotivationsMax = 6;
                    lAcclimationsMax = 3;
                    lStrainMax = 10;
                    break;
                case 20:
                    lAttributesMax = 20;
                    lCspMax = 25;
                    lNcspMax = 20;
                    lAbilityRankMax = 18;
                    lAbilityMasteryMax = 7;
                    lAbilitySynthesisMax = 2;
                    lAbilityOverloadMax = 4;
                    lMotivationsMax = 7;
                    lAcclimationsMax = 4;
                    lStrainMax = 10;
                    break;
                default:
                    lAttributesMax = 15;
                    lCspMax = 0;
                    lNcspMax = 0;
                    lAbilityRankMax = 3;
                    lAbilityMasteryMax = 0;
                    lAbilitySynthesisMax = 0;
                    lAbilityOverloadMax = 0;
                    lMotivationsMax = 3;
                    lAcclimationsMax = 0;
                    lStrainMax = 0;
                    break;
            }
            return;
        }
    }

    public static class EDATA
    {
        public static int eSkillType = 0;
        public static string eSkillName = " ";
        public static string eSkillRank = " ";

        public static string eAbilityName = " ";
        public static string eAbilityRank = " ";

        public static string numToInt(string num)
        {
            if (num == "I") return "1";
            else if (num == "II") return "2";
            else if (num == "III") return "3";
            else if (num == "IV") return "4";
            else if (num == "V") return "5";
            return "";
        }

        public static int numToRealInt(string num)
        {
            if (num == "I") return 1;
            else if (num == "II") return 2;
            else if (num == "III") return 3;
            else if (num == "IV") return 4;
            else if (num == "V") return 5;
            return 0;
        }

        public static int numToWeightedInt(string num)
        {
            if (num == "I") return 1;
            else if (num == "II") return 3;
            else if (num == "III") return 6;
            else if (num == "IV") return 10;
            else if (num == "V") return 15;
            return 0;
        }

        public static string intToNum(string num)
        {
            if (num == "1") return "I";
            else if (num == "2") return "II";
            else if (num == "3") return "III";
            else if (num == "4") return "IV";
            else if (num == "5") return "V";
            return " ";
        }

        public static string clearSpace(string input)
        {
            if (input == " ") return "";
            else return input;
        }

        public static string addSpace(string input)
        {
            if (input == "") return " ";
            else return input;
        }

        public static bool skillCheck(string input)
        {
            if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "") return true;
            else return false;
        }

        public static bool abilityCheck(string input)
        {
            if (input == "1" || input == "2" || input == "3" || input == "") return true;
            else return false;
        }
    }

    public static class SDATA
    {
        public static string sFilepath = "";
        public static string sFullData = "";

        public static void generateFile(string filepath)
        {
            if (CDATA.version == "v1.0")
            {
                if (File.Exists(filepath))
                {
                    File.Delete(filepath);
                }

                using (FileStream fs = File.Create(filepath))
                {
                    string saveString = "";
                    saveString += "EDIT AT YOUR OWN PERIL (HERE THERE BE DRAGONS)\r\n\r\n";
                    saveString += "Orpheus Manager:\r\n";
                    saveString += CDATA.version + "\r\n\r\n";
                    saveString += "The ORPHEUS Protocol:\r\n";
                    saveString += CDATA.gameVersion + "\r\n\r\n";
                    saveString += "Character Name:\r\n";
                    saveString += CDATA.cName + "\r\n\r\n";
                    saveString += "Level:\r\n";
                    saveString += CDATA.cLevel + "\r\n\r\n";
                    saveString += "Archetype 1:\r\n";
                    saveString += CDATA.cArch1 + "\r\n\r\n";
                    saveString += "Archetype 2:\r\n";
                    saveString += CDATA.cArch2 + "\r\n\r\n";
                    saveString += "Archetype 3:\r\n";
                    saveString += CDATA.cArch3 + "\r\n\r\n";
                    saveString += "Background:\r\n";
                    saveString += CDATA.cBackground + "\r\n\r\n";
                    saveString += "Attributes (PER, COG, DEX, VIT, CHAR, WILL):\r\n";
                    saveString += CDATA.cAttributes[0] + "\r\n";
                    saveString += CDATA.cAttributes[1] + "\r\n";
                    saveString += CDATA.cAttributes[2] + "\r\n";
                    saveString += CDATA.cAttributes[3] + "\r\n";
                    saveString += CDATA.cAttributes[4] + "\r\n";
                    saveString += CDATA.cAttributes[5] + "\r\n\r\n";
                    saveString += "Modifiers (PER, COG, DEX, VIT, CHAR, WILL):\r\n";
                    saveString += CDATA.cAttributesTemp[0] + "\r\n";
                    saveString += CDATA.cAttributesTemp[1] + "\r\n";
                    saveString += CDATA.cAttributesTemp[2] + "\r\n";
                    saveString += CDATA.cAttributesTemp[3] + "\r\n";
                    saveString += CDATA.cAttributesTemp[4] + "\r\n";
                    saveString += CDATA.cAttributesTemp[5] + "\r\n\r\n";
                    saveString += "Motivation 1:\r\n";
                    saveString += CDATA.cMot1 + "\r\n\r\n";
                    saveString += "Motivation 2:\r\n";
                    saveString += CDATA.cMot2 + "\r\n\r\n";
                    saveString += "Motivation 3:\r\n";
                    saveString += CDATA.cMot3 + "\r\n\r\n";
                    saveString += "Motivation 4:\r\n";
                    saveString += CDATA.cMot4 + "\r\n\r\n";
                    saveString += "Motivation 5:\r\n";
                    saveString += CDATA.cMot5 + "\r\n\r\n";
                    saveString += "Motivation 6:\r\n";
                    saveString += CDATA.cMot6 + "\r\n\r\n";
                    saveString += "Motivation 7:\r\n";
                    saveString += CDATA.cMot7 + "\r\n\r\n";
                    saveString += "Mental Strain:\r\n";
                    saveString += CDATA.cMentalStrain + "\r\n\r\n";
                    saveString += "Physical Strain:\r\n";
                    saveString += CDATA.cPhysicalStrain + "\r\n\r\n";
                    saveString += "Spiritual Strain:\r\n";
                    saveString += CDATA.cSpiritualStrain + "\r\n\r\n";
                    saveString += "Initiative:\r\n";
                    saveString += CDATA.cInitiative + "\r\n\r\n";
                    saveString += "Memento Mori:\r\n";
                    saveString += CDATA.cMementoMori + "\r\n\r\n";
                    saveString += "Humanity:\r\n";
                    saveString += CDATA.cHumanity + "\r\n\r\n";
                    saveString += "Humanity Max:\r\n";
                    saveString += CDATA.cHumanityMax + "\r\n\r\n";
                    saveString += "Over Focus:\r\n";
                    saveString += CDATA.cOverFocus + "\r\n\r\n";
                    saveString += "Over Health:\r\n";
                    saveString += CDATA.cOverHealth + "\r\n\r\n";
                    saveString += "Over Sanity:\r\n";
                    saveString += CDATA.cOverSanity + "\r\n\r\n";
                    saveString += "Initial CSP:\r\n";
                    saveString += CDATA.cInitialCsp + "\r\n\r\n";
                    saveString += "Initial NCSP:\r\n";
                    saveString += CDATA.cInitialNcsp + "\r\n\r\n";
                    saveString += "Acclimation 1:\r\n";
                    saveString += CDATA.cAcc1 + "\r\n\r\n";
                    saveString += "Acclimation 2:\r\n";
                    saveString += CDATA.cAcc2 + "\r\n\r\n";
                    saveString += "Acclimation 3:\r\n";
                    saveString += CDATA.cAcc3 + "\r\n\r\n";
                    saveString += "Acclimation 4:\r\n";
                    saveString += CDATA.cAcc4 + "\r\n\r\n";
                    saveString += "Focus Damage:\r\n";
                    saveString += CDATA.cFocusWounds[0] + "\r\n";
                    saveString += CDATA.cFocusWounds[1] + "\r\n";
                    saveString += CDATA.cFocusWounds[2] + "\r\n";
                    saveString += CDATA.cFocusWounds[3] + "\r\n";
                    saveString += CDATA.cFocusWounds[4] + "\r\n";
                    saveString += CDATA.cFocusWounds[5] + "\r\n";
                    saveString += CDATA.cFocusWounds[6] + "\r\n";
                    saveString += CDATA.cFocusWounds[7] + "\r\n";
                    saveString += CDATA.cFocusWounds[8] + "\r\n";
                    saveString += CDATA.cFocusWounds[9] + "\r\n\r\n";
                    saveString += "Health Damage:\r\n";
                    saveString += CDATA.cHealthWounds[0] + "\r\n";
                    saveString += CDATA.cHealthWounds[1] + "\r\n";
                    saveString += CDATA.cHealthWounds[2] + "\r\n";
                    saveString += CDATA.cHealthWounds[3] + "\r\n";
                    saveString += CDATA.cHealthWounds[4] + "\r\n";
                    saveString += CDATA.cHealthWounds[5] + "\r\n";
                    saveString += CDATA.cHealthWounds[6] + "\r\n";
                    saveString += CDATA.cHealthWounds[7] + "\r\n";
                    saveString += CDATA.cHealthWounds[8] + "\r\n";
                    saveString += CDATA.cHealthWounds[9] + "\r\n\r\n";
                    saveString += "Sanity Damage:\r\n";
                    saveString += CDATA.cSanityWounds[0] + "\r\n";
                    saveString += CDATA.cSanityWounds[1] + "\r\n";
                    saveString += CDATA.cSanityWounds[2] + "\r\n";
                    saveString += CDATA.cSanityWounds[3] + "\r\n";
                    saveString += CDATA.cSanityWounds[4] + "\r\n";
                    saveString += CDATA.cSanityWounds[5] + "\r\n";
                    saveString += CDATA.cSanityWounds[6] + "\r\n";
                    saveString += CDATA.cSanityWounds[7] + "\r\n";
                    saveString += CDATA.cSanityWounds[8] + "\r\n";
                    saveString += CDATA.cSanityWounds[9] + "\r\n\r\n";
                    saveString += "Skills:\r\n";
                    saveString += CDATA.cSkillName[0] + "\r\n";
                    saveString += CDATA.cSkillRank[0] + "\r\n";
                    saveString += CDATA.cSkillName[1] + "\r\n";
                    saveString += CDATA.cSkillRank[1] + "\r\n";
                    saveString += CDATA.cSkillName[2] + "\r\n";
                    saveString += CDATA.cSkillRank[2] + "\r\n";
                    saveString += CDATA.cSkillName[3] + "\r\n";
                    saveString += CDATA.cSkillRank[3] + "\r\n";
                    saveString += CDATA.cSkillName[4] + "\r\n";
                    saveString += CDATA.cSkillRank[4] + "\r\n";
                    saveString += CDATA.cSkillName[5] + "\r\n";
                    saveString += CDATA.cSkillRank[5] + "\r\n";
                    saveString += CDATA.cSkillName[6] + "\r\n";
                    saveString += CDATA.cSkillRank[6] + "\r\n";
                    saveString += CDATA.cSkillName[7] + "\r\n";
                    saveString += CDATA.cSkillRank[7] + "\r\n";
                    saveString += CDATA.cSkillName[8] + "\r\n";
                    saveString += CDATA.cSkillRank[8] + "\r\n";
                    saveString += CDATA.cSkillName[9] + "\r\n";
                    saveString += CDATA.cSkillRank[9] + "\r\n";
                    saveString += CDATA.cSkillName[10] + "\r\n";
                    saveString += CDATA.cSkillRank[10] + "\r\n";
                    saveString += CDATA.cSkillName[11] + "\r\n";
                    saveString += CDATA.cSkillRank[11] + "\r\n";
                    saveString += CDATA.cSkillName[12] + "\r\n";
                    saveString += CDATA.cSkillRank[12] + "\r\n";
                    saveString += CDATA.cSkillName[13] + "\r\n";
                    saveString += CDATA.cSkillRank[13] + "\r\n";
                    saveString += CDATA.cSkillName[14] + "\r\n";
                    saveString += CDATA.cSkillRank[14] + "\r\n";
                    saveString += CDATA.cSkillName[15] + "\r\n";
                    saveString += CDATA.cSkillRank[15] + "\r\n";
                    saveString += CDATA.cSkillName[16] + "\r\n";
                    saveString += CDATA.cSkillRank[16] + "\r\n";
                    saveString += CDATA.cSkillName[17] + "\r\n";
                    saveString += CDATA.cSkillRank[17] + "\r\n";
                    saveString += CDATA.cSkillName[18] + "\r\n";
                    saveString += CDATA.cSkillRank[18] + "\r\n";
                    saveString += CDATA.cSkillName[19] + "\r\n";
                    saveString += CDATA.cSkillRank[19] + "\r\n";
                    saveString += "Combat Skills:\r\n";
                    saveString += CDATA.cCkillName[0] + "\r\n";
                    saveString += CDATA.cCkillRank[0] + "\r\n";
                    saveString += CDATA.cCkillName[1] + "\r\n";
                    saveString += CDATA.cCkillRank[1] + "\r\n";
                    saveString += CDATA.cCkillName[2] + "\r\n";
                    saveString += CDATA.cCkillRank[2] + "\r\n";
                    saveString += CDATA.cCkillName[3] + "\r\n";
                    saveString += CDATA.cCkillRank[3] + "\r\n";
                    saveString += CDATA.cCkillName[4] + "\r\n";
                    saveString += CDATA.cCkillRank[4] + "\r\n";
                    saveString += CDATA.cCkillName[5] + "\r\n";
                    saveString += CDATA.cCkillRank[5] + "\r\n";
                    saveString += CDATA.cCkillName[6] + "\r\n";
                    saveString += CDATA.cCkillRank[6] + "\r\n";
                    saveString += CDATA.cCkillName[7] + "\r\n";
                    saveString += CDATA.cCkillRank[7] + "\r\n";
                    saveString += CDATA.cCkillName[8] + "\r\n";
                    saveString += CDATA.cCkillRank[8] + "\r\n";
                    saveString += CDATA.cCkillName[9] + "\r\n";
                    saveString += CDATA.cCkillRank[9] + "\r\n";
                    saveString += CDATA.cCkillName[10] + "\r\n";
                    saveString += CDATA.cCkillRank[10] + "\r\n";
                    saveString += CDATA.cCkillName[11] + "\r\n";
                    saveString += CDATA.cCkillRank[11] + "\r\n";
                    saveString += CDATA.cCkillName[12] + "\r\n";
                    saveString += CDATA.cCkillRank[12] + "\r\n";
                    saveString += CDATA.cCkillName[13] + "\r\n";
                    saveString += CDATA.cCkillRank[13] + "\r\n";
                    saveString += CDATA.cCkillName[14] + "\r\n";
                    saveString += CDATA.cCkillRank[14] + "\r\n";
                    saveString += CDATA.cCkillName[15] + "\r\n";
                    saveString += CDATA.cCkillRank[15] + "\r\n";
                    saveString += CDATA.cCkillName[16] + "\r\n";
                    saveString += CDATA.cCkillRank[16] + "\r\n";
                    saveString += CDATA.cCkillName[17] + "\r\n";
                    saveString += CDATA.cCkillRank[17] + "\r\n";
                    saveString += CDATA.cCkillName[18] + "\r\n";
                    saveString += CDATA.cCkillRank[18] + "\r\n";
                    saveString += CDATA.cCkillName[19] + "\r\n";
                    saveString += CDATA.cCkillRank[19] + "\r\n";
                    saveString += "Abilities:\r\n";
                    saveString += CDATA.cAbilityName[0] + "\r\n";
                    saveString += CDATA.cAbilityRank[0] + "\r\n";
                    saveString += CDATA.cAbilityName[1] + "\r\n";
                    saveString += CDATA.cAbilityRank[1] + "\r\n";
                    saveString += CDATA.cAbilityName[2] + "\r\n";
                    saveString += CDATA.cAbilityRank[2] + "\r\n";
                    saveString += CDATA.cAbilityName[3] + "\r\n";
                    saveString += CDATA.cAbilityRank[3] + "\r\n";
                    saveString += CDATA.cAbilityName[4] + "\r\n";
                    saveString += CDATA.cAbilityRank[4] + "\r\n";
                    saveString += CDATA.cAbilityName[5] + "\r\n";
                    saveString += CDATA.cAbilityRank[5] + "\r\n";
                    saveString += CDATA.cAbilityName[6] + "\r\n";
                    saveString += CDATA.cAbilityRank[6] + "\r\n";
                    saveString += CDATA.cAbilityName[7] + "\r\n";
                    saveString += CDATA.cAbilityRank[7] + "\r\n";
                    saveString += CDATA.cAbilityName[8] + "\r\n";
                    saveString += CDATA.cAbilityRank[8] + "\r\n";
                    saveString += CDATA.cAbilityName[9] + "\r\n";
                    saveString += CDATA.cAbilityRank[9] + "\r\n";
                    saveString += CDATA.cAbilityName[10] + "\r\n";
                    saveString += CDATA.cAbilityRank[10] + "\r\n";
                    saveString += CDATA.cAbilityName[11] + "\r\n";
                    saveString += CDATA.cAbilityRank[11] + "\r\n\r\n";
                    saveString += "Motivation 1 Boxes:\r\n";
                    saveString += CDATA.cMot1Box[0] + "\r\n";
                    saveString += CDATA.cMot1Box[1] + "\r\n";
                    saveString += CDATA.cMot1Box[2] + "\r\n";
                    saveString += CDATA.cMot1Box[3] + "\r\n";
                    saveString += CDATA.cMot1Box[4] + "\r\n";
                    saveString += CDATA.cMot1Box[5] + "\r\n\r\n";
                    saveString += "Motivation 2 Boxes:\r\n";
                    saveString += CDATA.cMot2Box[0] + "\r\n";
                    saveString += CDATA.cMot2Box[1] + "\r\n";
                    saveString += CDATA.cMot2Box[2] + "\r\n";
                    saveString += CDATA.cMot2Box[3] + "\r\n";
                    saveString += CDATA.cMot2Box[4] + "\r\n";
                    saveString += CDATA.cMot2Box[5] + "\r\n\r\n";
                    saveString += "Motivation 3 Boxes:\r\n";
                    saveString += CDATA.cMot3Box[0] + "\r\n";
                    saveString += CDATA.cMot3Box[1] + "\r\n";
                    saveString += CDATA.cMot3Box[2] + "\r\n";
                    saveString += CDATA.cMot3Box[3] + "\r\n";
                    saveString += CDATA.cMot3Box[4] + "\r\n";
                    saveString += CDATA.cMot3Box[5] + "\r\n\r\n";
                    saveString += "Motivation 4 Boxes:\r\n";
                    saveString += CDATA.cMot4Box[0] + "\r\n";
                    saveString += CDATA.cMot4Box[1] + "\r\n";
                    saveString += CDATA.cMot4Box[2] + "\r\n";
                    saveString += CDATA.cMot4Box[3] + "\r\n";
                    saveString += CDATA.cMot4Box[4] + "\r\n";
                    saveString += CDATA.cMot4Box[5] + "\r\n\r\n";
                    saveString += "Motivation 5 Boxes:\r\n";
                    saveString += CDATA.cMot5Box[0] + "\r\n";
                    saveString += CDATA.cMot5Box[1] + "\r\n";
                    saveString += CDATA.cMot5Box[2] + "\r\n";
                    saveString += CDATA.cMot5Box[3] + "\r\n";
                    saveString += CDATA.cMot5Box[4] + "\r\n";
                    saveString += CDATA.cMot5Box[5] + "\r\n\r\n";
                    saveString += "Motivation 6 Boxes:\r\n";
                    saveString += CDATA.cMot6Box[0] + "\r\n";
                    saveString += CDATA.cMot6Box[1] + "\r\n";
                    saveString += CDATA.cMot6Box[2] + "\r\n";
                    saveString += CDATA.cMot6Box[3] + "\r\n";
                    saveString += CDATA.cMot6Box[4] + "\r\n";
                    saveString += CDATA.cMot6Box[5] + "\r\n\r\n";
                    saveString += "Motivation 7 Boxes:\r\n";
                    saveString += CDATA.cMot7Box[0] + "\r\n";
                    saveString += CDATA.cMot7Box[1] + "\r\n";
                    saveString += CDATA.cMot7Box[2] + "\r\n";
                    saveString += CDATA.cMot7Box[3] + "\r\n";
                    saveString += CDATA.cMot7Box[4] + "\r\n";
                    saveString += CDATA.cMot7Box[5] + "\r\n\r\n";
                    saveString += "Ability Mastery A:\r\n";
                    saveString += CDATA.cAbilityMasteryA[0] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[1] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[2] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[3] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[4] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[5] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[6] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[7] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[8] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[9] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[10] + "\r\n";
                    saveString += CDATA.cAbilityMasteryA[11] + "\r\n\r\n";
                    saveString += "Ability Mastery B:\r\n";
                    saveString += CDATA.cAbilityMasteryB[0] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[1] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[2] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[3] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[4] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[5] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[6] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[7] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[8] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[9] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[10] + "\r\n";
                    saveString += CDATA.cAbilityMasteryB[11] + "\r\n\r\n";
                    saveString += "Ability Overload:\r\n";
                    saveString += CDATA.cAbilityOverload[0] + "\r\n";
                    saveString += CDATA.cAbilityOverload[1] + "\r\n";
                    saveString += CDATA.cAbilityOverload[2] + "\r\n";
                    saveString += CDATA.cAbilityOverload[3] + "\r\n";
                    saveString += CDATA.cAbilityOverload[4] + "\r\n";
                    saveString += CDATA.cAbilityOverload[5] + "\r\n";
                    saveString += CDATA.cAbilityOverload[6] + "\r\n";
                    saveString += CDATA.cAbilityOverload[7] + "\r\n";
                    saveString += CDATA.cAbilityOverload[8] + "\r\n";
                    saveString += CDATA.cAbilityOverload[9] + "\r\n";
                    saveString += CDATA.cAbilityOverload[10] + "\r\n";
                    saveString += CDATA.cAbilityOverload[11] + "\r\n\r\n";
                    saveString += "Mental Strain Modifier:\r\n";
                    saveString += CDATA.cMaxMentStrain + "\r\n\r\n";
                    saveString += "Physical Strain Modifier:\r\n";
                    saveString += CDATA.cMaxPhysStrain + "\r\n\r\n";
                    saveString += "Spiritual Strain Modifier:\r\n";
                    saveString += CDATA.cMaxSpirStrain + "\r\n\r\n";
                    saveString += "Notes:\r\n";
                    saveString += CDATA.cNotes + "[XXspecialENDstringXX]\r\n\r\n";

                    saveString += "Orpheus Manager by Jason Brown\r\nFind me on Twitter @Blooperly_";

                    byte[] saveData = new UTF8Encoding(true).GetBytes(saveString);
                    fs.Write(saveData, 0, saveData.Length);
                }
            }
        }

        public static string parseField(string search)
        {
            int start = 0;
            int end = 0;
            int len = 0;
            start = SDATA.sFullData.IndexOf(search, 0) + search.Length;
            end = SDATA.sFullData.IndexOf("\r\n\r\n", start);
            len = end - start;
            if (len > 0) return SDATA.sFullData.Substring(start, len);
            else return " ";
        }

        public static string parseFieldEnd(string search)
        {
            int start = 0;
            int end = 0;
            int len = 0;
            start = SDATA.sFullData.IndexOf(search, 0) + search.Length;
            end = SDATA.sFullData.IndexOf("[XXspecialENDstringXX]\r\n\r\n", start);
            len = end - start;
            if (len > 0) return SDATA.sFullData.Substring(start, len);
            else return " ";
        }

        public static string parseLine(string source, int line)
        {
            int start = 0;
            int end = 0;
            int len = 0;
            for (int i = 0; i <= line; i++)
            {
                end = source.IndexOf("\r\n", start);
                start = end + 2;
            }
            if (line == 0) start = 0;
            else
            {
                start = 0;
                for (int i = 0; i < line; i++)
                {
                    len = source.IndexOf("\r\n", start);
                    start = len + 2;
                }
            }
            len = end - start;
            if (len > 0) return source.Substring(start, len);
            else return " ";
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static CharacterSheet mainform;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainform = new CharacterSheet();
            Application.Run(mainform);
        }
    }
}
