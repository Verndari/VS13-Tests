using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroesTalentBuilder
{
    public partial class Form1 : Form
    {

        string skilltext = "Klicke auf das Skill Icon für den erweiterten Tooltip.";
        
        public Form1()
        {
            InitializeComponent();

            this.MouseWheel += new MouseEventHandler(tab_MouseWheel);

            // Nova Skill Tooltip Start

            new ToolTip().SetToolTip(novaSkill1, SkillsToolTip.NovaTooltip.heckenschuetzetooltip);
            new ToolTip().SetToolTip(novaSkill4, SkillsToolTip.NovaTooltip.energiesammelntooltip);
            new ToolTip().SetToolTip(novaSkill7, SkillsToolTip.NovaTooltip.panzerbrechendetooltip);
            new ToolTip().SetToolTip(novaSkill10, SkillsToolTip.NovaTooltip.praezisionsschlagtooltip);
            new ToolTip().SetToolTip(novaSkill13, SkillsToolTip.NovaTooltip.tarnungtooltip);
            new ToolTip().SetToolTip(novaSkill16, SkillsToolTip.NovaTooltip.verkrueppelnderschusstooltip);
            new ToolTip().SetToolTip(novaSkill20, SkillsToolTip.NovaTooltip.blitzschlagtooltip);

            // Nova Skill Tooltip Ende ---

            // Jaina Skill Tooltip Start ---

            new ToolTip().SetToolTip(jainaSkill1, SkillsToolTip.JainaToolTip.eiseskaeltetooltip);
            new ToolTip().SetToolTip(jainaSkill4, SkillsToolTip.JainaToolTip.frostsplittertooltip);
            new ToolTip().SetToolTip(jainaSkill7, SkillsToolTip.JainaToolTip.eislanzetooltip);
            new ToolTip().SetToolTip(jainaSkill10, SkillsToolTip.JainaToolTip.wasserelementartooltip);
            new ToolTip().SetToolTip(jainaSkill13, SkillsToolTip.JainaToolTip.eisigeaderntooltip);
            new ToolTip().SetToolTip(jainaSkill16, SkillsToolTip.JainaToolTip.schneidenderwindtooltip);
            new ToolTip().SetToolTip(jainaSkill20, SkillsToolTip.JainaToolTip.altvaterwintertooltip);

            new ToolTip().SetToolTip(jainaSkill12, SkillsToolTip.JainaToolTip.griffdeswinterstooltip);
            new ToolTip().SetToolTip(jainaSkill42, SkillsToolTip.JainaToolTip.vergiftentooltip);
            new ToolTip().SetToolTip(jainaSkill72, SkillsToolTip.JainaToolTip.eislanzetooltip);
            new ToolTip().SetToolTip(jainaSkill102, SkillsToolTip.JainaToolTip.ringdesfrostestooltip);
            new ToolTip().SetToolTip(jainaSkill132, SkillsToolTip.JainaToolTip.verbessertereinsblocktooltip);
            new ToolTip().SetToolTip(jainaSkill162, SkillsToolTip.JainaToolTip.kaltefuessetooltip);
            new ToolTip().SetToolTip(jainaSkill202, SkillsToolTip.JainaToolTip.blitzschlagdessturmstooltip);

            // Jaina Skill Tooltip Ende ---

            // Raynor Skill Tooltip Start ---

            new ToolTip().SetToolTip(raynorSkill1, SkillsToolTip.RaynorToolTip.ichwillmehrtooltip);
            new ToolTip().SetToolTip(raynorSkill4, SkillsToolTip.RaynorToolTip.fokussierterangrifftooltip);
            new ToolTip().SetToolTip(raynorSkill7, SkillsToolTip.RaynorToolTip.gangzulegentooltip);
            new ToolTip().SetToolTip(raynorSkill10, SkillsToolTip.RaynorToolTip.raynorsraidertooltip);
            new ToolTip().SetToolTip(raynorSkill16, SkillsToolTip.RaynorToolTip.insschwarzetooltip);           
            new ToolTip().SetToolTip(raynorSkill20, SkillsToolTip.RaynorToolTip.helsangelstooltip);

            // Raynor Skill Tooltip Ende ---

            // Valla Skill Tooltip Start ---

            new ToolTip().SetToolTip(vallaSkill1, SkillsToolTip.VallaTooltip.kompositpfeiletooltip);
            new ToolTip().SetToolTip(vallaSkill4, SkillsToolTip.VallaTooltip.arsenaltooltip);
            new ToolTip().SetToolTip(vallaSkill7, SkillsToolTip.VallaTooltip.eiferdesgefechtstooltip);
            new ToolTip().SetToolTip(vallaSkill10, SkillsToolTip.VallaTooltip.sperrfeuertooltip);
            new ToolTip().SetToolTip(vallaSkill13, SkillsToolTip.VallaTooltip.frostschusstooltip);
            new ToolTip().SetToolTip(vallaSkill16, SkillsToolTip.VallaTooltip.blutfuerbluttooltip);
            new ToolTip().SetToolTip(vallaSkill20, SkillsToolTip.JainaToolTip.blitzschlagdessturmstooltip);

            new ToolTip().SetToolTip(vallaSkill12, SkillsToolTip.VallaTooltip.grolltooltip);
            new ToolTip().SetToolTip(vallaSkill42, SkillsToolTip.VallaTooltip.mantikortooltip);
            new ToolTip().SetToolTip(vallaSkill72, SkillsToolTip.VallaTooltip.senfendeangriffetooltip);
            new ToolTip().SetToolTip(vallaSkill102, SkillsToolTip.VallaTooltip.rachehageltooltip);
            new ToolTip().SetToolTip(vallaSkill132, SkillsToolTip.VallaTooltip.zauberschildtooltip);
            new ToolTip().SetToolTip(vallaSkill162, SkillsToolTip.VallaTooltip.blutfuerbluttooltip);
            new ToolTip().SetToolTip(vallaSkill202, SkillsToolTip.JainaToolTip.blitzschlagdessturmstooltip);

            // Valla Skill Tooltip Ende ---

            // Sonya Skill Tooltip Start ---

            new ToolTip().SetToolTip(sonyaSkill1, SkillsToolTip.SonyaToolTip.wutanstiegtooltip);
            new ToolTip().SetToolTip(sonyaSkill4, SkillsToolTip.SonyaToolTip.wuetenderschlagtooltip);
            new ToolTip().SetToolTip(sonyaSkill7, SkillsToolTip.SonyaToolTip.zerborstenerbodentooltip);
            new ToolTip().SetToolTip(sonyaSkill10, SkillsToolTip.SonyaToolTip.sprungoffensivetooltip);
            new ToolTip().SetToolTip(sonyaSkill13, SkillsToolTip.VallaTooltip.zauberschildtooltip);
            new ToolTip().SetToolTip(sonyaSkill16, SkillsToolTip.SonyaToolTip.steinhauttooltip);
            new ToolTip().SetToolTip(sonyaSkill20, SkillsToolTip.SonyaToolTip.arreatkratertooltip);

            // Sonya Skill Tooltip Ende ---

        }

        // Tab Scroll function Start ---

        private void tab_MouseWheel(object sender, MouseEventArgs e)
        {
            jainaTab.Focus();
            vallaTab.Focus();
            muradinTab.Focus();
        }

        // Tab Scroll function Ende ---

        // Nova Skills Info Start ---

        private void novaAvatar_Click(object sender, EventArgs e)
        {
            if (novaSkillinfo.Text == SkillsToolTip.NovaTooltip.novatooltip)
            {
                novaSkillinfo.Text = skilltext;
            }
            else
            {
                novaSkillinfo.Text = SkillsToolTip.NovaTooltip.novatooltip;
            }
        }

        private void novaSkill1_Click(object sender, EventArgs e)
        {
            if (novaSkillinfo.Text == KlassenSkills.Novaskills.heckenschuetze)
            {
                novaSkillinfo.Text = skilltext;
            }
            else
            {
                novaSkillinfo.Text = KlassenSkills.Novaskills.heckenschuetze;
            }
        }

        private void novaSkill4_Click(object sender, EventArgs e)
        {
            if (novaSkillinfo.Text == KlassenSkills.Novaskills.energiesammeln)
            {
                novaSkillinfo.Text = skilltext;
            }
            else
            {
                novaSkillinfo.Text = KlassenSkills.Novaskills.energiesammeln;
            }
        }

        private void novaSkill7_Click(object sender, EventArgs e)
        {
            if (novaSkillinfo.Text == KlassenSkills.Novaskills.panzerbrechendemunition)
            {
                novaSkillinfo.Text = skilltext;
            }
            else
            {
                novaSkillinfo.Text = KlassenSkills.Novaskills.panzerbrechendemunition;
            }
        }

        private void novaSkill10_Click(object sender, EventArgs e)
        {
            if (novaSkillinfo.Text == KlassenSkills.Novaskills.praezisionsschlag)
            {
                novaSkillinfo.Text = skilltext;
            }
            else
            {
                novaSkillinfo.Text = KlassenSkills.Novaskills.praezisionsschlag;
            }    
        }

        private void novaSkill13_Click(object sender, EventArgs e)
        {
            if (novaSkillinfo.Text == KlassenSkills.Novaskills.verbessertetarnung)
            {
                novaSkillinfo.Text = skilltext;
            }
            else
            {
                novaSkillinfo.Text = KlassenSkills.Novaskills.verbessertetarnung;
            }
        }

        private void novaSkill16_Click(object sender, EventArgs e)
        {
            if (novaSkillinfo.Text == KlassenSkills.Novaskills.verkrueppelnderschuss)
            {
                novaSkillinfo.Text = skilltext;
            }
            else
            {
                novaSkillinfo.Text = KlassenSkills.Novaskills.verkrueppelnderschuss;
            } 
        }

        private void novaSkill20_Click(object sender, EventArgs e)
        {
            if (novaSkillinfo.Text == KlassenSkills.Novaskills.blitzschlagdessturms)
            {
                novaSkillinfo.Text = skilltext;
            }
            else
            {
                novaSkillinfo.Text = KlassenSkills.Novaskills.blitzschlagdessturms;
            }
        }

        // Nova Skills Info Ende ---

        // Jaina Skills Info Start ---

        private void jainaAvatar_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo.Text == SkillsToolTip.JainaToolTip.jainatooltip)
            {
                jainaSkillinfo.Text = skilltext;
            }
            else
            {
                jainaSkillinfo.Text = SkillsToolTip.JainaToolTip.jainatooltip;
            }
        }
        
        private void jainaSkill1_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo.Text == KlassenSkills.JainaSkills.eiseskaelte)
            {
                jainaSkillinfo.Text = skilltext;
            }
            else
            {
                jainaSkillinfo.Text = KlassenSkills.JainaSkills.eiseskaelte;
            }
        }

        private void jainaSkill4_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo.Text == KlassenSkills.JainaSkills.frostsplitter)
            {
                jainaSkillinfo.Text = skilltext;
            }
            else
            {
                jainaSkillinfo.Text = KlassenSkills.JainaSkills.frostsplitter;
            }
        }

        private void jainaSkill7_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo.Text == KlassenSkills.JainaSkills.eislanze)
            {
                jainaSkillinfo.Text = skilltext;
            }
            else
            {
                jainaSkillinfo.Text = KlassenSkills.JainaSkills.eislanze;
            }
        }

        private void jainaSkill10_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo.Text == KlassenSkills.JainaSkills.wasserelementar)
            {
                jainaSkillinfo.Text = skilltext;
            }
            else
            {
                jainaSkillinfo.Text = KlassenSkills.JainaSkills.wasserelementar;
            }
        }

        private void jainaSkill13_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo.Text == KlassenSkills.JainaSkills.eisigeadern)
            {
                jainaSkillinfo.Text = skilltext;
            }
            else
            {
                jainaSkillinfo.Text = KlassenSkills.JainaSkills.eisigeadern;
            }
        }

        private void jainaSkill16_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo.Text == KlassenSkills.JainaSkills.schneidenderwind)
            {
                jainaSkillinfo.Text = skilltext;
            }
            else
            {
                jainaSkillinfo.Text = KlassenSkills.JainaSkills.schneidenderwind;
            }
        }

        private void jainaSkill20_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo.Text == KlassenSkills.JainaSkills.altvatarwinder)
            {
                jainaSkillinfo.Text = skilltext;
            }
            else
            {
                jainaSkillinfo.Text = KlassenSkills.JainaSkills.altvatarwinder;
            }
        }

        
        private void jainaSkill12_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo2.Text == KlassenSkills.JainaSkills.griffdeswinters)
            {
                jainaSkillinfo2.Text = skilltext;
            }
            else
            {
                jainaSkillinfo2.Text = KlassenSkills.JainaSkills.griffdeswinters;
            }
        }

        private void jainaSkill42_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo2.Text == KlassenSkills.JainaSkills.vergiften)
            {
                jainaSkillinfo2.Text = skilltext;
            }
            else
            {
                jainaSkillinfo2.Text = KlassenSkills.JainaSkills.vergiften;
            }
        }

        private void jainaSkill72_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo2.Text == KlassenSkills.JainaSkills.eislanze)
            {
                jainaSkillinfo2.Text = skilltext;
            }
            else
            {
                jainaSkillinfo2.Text = KlassenSkills.JainaSkills.eislanze;
            }
        }

        private void jainaSkill102_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo2.Text == KlassenSkills.JainaSkills.ringdesfrosts)
            {
                jainaSkillinfo2.Text = skilltext;
            }
            else
            {
                jainaSkillinfo2.Text = KlassenSkills.JainaSkills.ringdesfrosts;
            }
        }

        private void jainaSkill132_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo2.Text == KlassenSkills.JainaSkills.verbessertereisblock)
            {
                jainaSkillinfo2.Text = skilltext;
            }
            else
            {
                jainaSkillinfo2.Text = KlassenSkills.JainaSkills.verbessertereisblock;
            }
        }

        private void jainaSkill162_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo2.Text == KlassenSkills.JainaSkills.kaltefuesse)
            {
                jainaSkillinfo2.Text = skilltext;
            }
            else
            {
                jainaSkillinfo2.Text = KlassenSkills.JainaSkills.kaltefuesse;
            }
        }

        private void jainaSkill202_Click(object sender, EventArgs e)
        {
            if (jainaSkillinfo2.Text == KlassenSkills.JainaSkills.blitschlagdessturms)
            {
                jainaSkillinfo2.Text = skilltext;
            }
            else
            {
                jainaSkillinfo2.Text = KlassenSkills.JainaSkills.blitschlagdessturms;
            }
        }

        // Jaina Skills Info Ende ---

        // Raynor Skills Info Start ---

        private void raynorAvatar_Click(object sender, EventArgs e)
        {
            if (raynorSkillinfo.Text == SkillsToolTip.RaynorToolTip.raynortooltip)
            {
                raynorSkillinfo.Text = skilltext;
            }
            else
            {
                raynorSkillinfo.Text = SkillsToolTip.RaynorToolTip.raynortooltip;
            }
        }

        private void raynorSkill1_Click(object sender, EventArgs e)
        {
            if (raynorSkillinfo.Text == KlassenSkills.Raynorskills.ichwillmehr)
            {
                raynorSkillinfo.Text = skilltext;
            }
            else
            {
                raynorSkillinfo.Text = KlassenSkills.Raynorskills.ichwillmehr;
            }
        }

        private void raynorSkill4_Click(object sender, EventArgs e)
        {
            if (raynorSkillinfo.Text == KlassenSkills.Raynorskills.fokussierterangriff)
            {
                raynorSkillinfo.Text = skilltext;
            }
            else
            {
                raynorSkillinfo.Text = KlassenSkills.Raynorskills.fokussierterangriff;
            }
        }

        private void raynorSkill7_Click(object sender, EventArgs e)
        {
            if (raynorSkillinfo.Text == KlassenSkills.Raynorskills.gangzulegen)
            {
                raynorSkillinfo.Text = skilltext;
            }
            else
            {
                raynorSkillinfo.Text = KlassenSkills.Raynorskills.gangzulegen;
            }
        }

        private void raynorSkill10_Click(object sender, EventArgs e)
        {
            if (raynorSkillinfo.Text == KlassenSkills.Raynorskills.raynorsraiders)
            {
                raynorSkillinfo.Text = skilltext;
            }
            else
            {
                raynorSkillinfo.Text = KlassenSkills.Raynorskills.raynorsraiders;
            }
        }

        private void raynorSkill13_Click(object sender, EventArgs e)
        {
            if (raynorSkillinfo.Text == KlassenSkills.Raynorskills.riesentoeter)
            {
                raynorSkillinfo.Text = skilltext;
            }
            else
            {
                raynorSkillinfo.Text = KlassenSkills.Raynorskills.riesentoeter;
            }
        }

        private void raynorSkill16_Click(object sender, EventArgs e)
        {
            if (raynorSkillinfo.Text == KlassenSkills.Raynorskills.insschwarze)
            {
                raynorSkillinfo.Text = skilltext;
            }
            else
            {
                raynorSkillinfo.Text = KlassenSkills.Raynorskills.insschwarze;
            }
        }

        private void raynorSkill20_Click(object sender, EventArgs e)
        {
            if (raynorSkillinfo.Text == KlassenSkills.Raynorskills.helsangels)
            {
                raynorSkillinfo.Text = skilltext;
            }
            else
            {
                raynorSkillinfo.Text = KlassenSkills.Raynorskills.helsangels;
            }
        }

        // Raynor Skills Info Ende ---

        // Valla Skills Info Start ---

        private void vallaAvatar_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo.Text == SkillsToolTip.VallaTooltip.vallaavatar)
            {
                vallaSkillinfo.Text = skilltext;
            }
            else
            {
                vallaSkillinfo.Text = SkillsToolTip.VallaTooltip.vallaavatar;
            }
        }
        
        private void vallaSkill1_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo.Text == KlassenSkills.VallaSkills.kompositpfeil)
            {
                vallaSkillinfo.Text = skilltext;
            } else {
                vallaSkillinfo.Text = KlassenSkills.VallaSkills.kompositpfeil;
            }

        }

        private void vallaSkill4_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo.Text == KlassenSkills.VallaSkills.arsenal)
            {
                vallaSkillinfo.Text = skilltext;
            }
            else
            {
                vallaSkillinfo.Text = KlassenSkills.VallaSkills.arsenal;
            }
        }

        private void vallaSkill7_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo.Text == KlassenSkills.VallaSkills.eiferdesgefechts)
            {
                vallaSkillinfo.Text = skilltext;
            }
            else
            {
                vallaSkillinfo.Text = KlassenSkills.VallaSkills.eiferdesgefechts;
            }
        }

        private void vallaSkill10_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo.Text == KlassenSkills.VallaSkills.sperrfeuer)
            {
                vallaSkillinfo.Text = skilltext;
            }
            else
            {
                vallaSkillinfo.Text = KlassenSkills.VallaSkills.sperrfeuer;
            }
        }

        private void vallaSkill13_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo.Text == KlassenSkills.VallaSkills.frostschuss)
            {
                vallaSkillinfo.Text = skilltext;
            }
            else
            {
                vallaSkillinfo.Text = KlassenSkills.VallaSkills.frostschuss;
            }
        }

        private void vallaSkill16_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo.Text == KlassenSkills.VallaSkills.blutfuerblut)
            {
                vallaSkillinfo.Text = skilltext;
            }
            else
            {
                vallaSkillinfo.Text = KlassenSkills.VallaSkills.blutfuerblut;
            }
        }

        private void vallaSkill20_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo.Text == KlassenSkills.JainaSkills.blitschlagdessturms)
            {
                vallaSkillinfo.Text = skilltext;
            }
            else
            {
                vallaSkillinfo.Text = KlassenSkills.JainaSkills.blitschlagdessturms;
            }
        }


        private void vallaSkill12_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo2.Text == KlassenSkills.VallaSkills.groll)
            {
                vallaSkillinfo2.Text = skilltext;
            }
            else
            {
                vallaSkillinfo2.Text = KlassenSkills.VallaSkills.groll;
            }
        }

        private void vallaSkill14_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo2.Text == KlassenSkills.VallaSkills.mantikor)
            {
                vallaSkillinfo2.Text = skilltext;
            }
            else
            {
                vallaSkillinfo2.Text = KlassenSkills.VallaSkills.mantikor;
            }
        }

        private void vallaSkill17_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo2.Text == KlassenSkills.VallaSkills.sengendeangriffe)
            {
                vallaSkillinfo2.Text = skilltext;
            }
            else
            {
                vallaSkillinfo2.Text = KlassenSkills.VallaSkills.sengendeangriffe;
            }
        }

        private void vallaSkill102_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo2.Text == KlassenSkills.VallaSkills.rachehagel)
            {
                vallaSkillinfo2.Text = skilltext;
            }
            else
            {
                vallaSkillinfo2.Text = KlassenSkills.VallaSkills.rachehagel;
            }
        }

        private void vallaSkill132_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo2.Text == KlassenSkills.VallaSkills.zauberschild)
            {
                vallaSkillinfo2.Text = skilltext;
            }
            else
            {
                vallaSkillinfo2.Text = KlassenSkills.VallaSkills.zauberschild;
            }
        }

        private void vallaSkill162_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo2.Text == KlassenSkills.VallaSkills.blutfuerblut)
            {
                vallaSkillinfo2.Text = skilltext;
            }
            else
            {
                vallaSkillinfo2.Text = KlassenSkills.VallaSkills.blutfuerblut;
            }
        }

        private void vallaSkill202_Click(object sender, EventArgs e)
        {
            if (vallaSkillinfo2.Text == KlassenSkills.JainaSkills.blitschlagdessturms)
            {
                vallaSkillinfo2.Text = skilltext;
            }
            else
            {
                vallaSkillinfo2.Text = KlassenSkills.JainaSkills.blitschlagdessturms;
            }
        }

        // Valla Skills Info Ende ---

        // Sonya Skills Info Start ---

        private void sonyaAvatar_Click(object sender, EventArgs e)
        {
            if (sonyaSkillinfo.Text == SkillsToolTip.SonyaToolTip.sonyaTooltip)
            {
                sonyaSkillinfo.Text = skilltext;
            }
            else
            {
                sonyaSkillinfo.Text = SkillsToolTip.SonyaToolTip.sonyaTooltip;
            }
        }

        private void sonyaSkill1_Click(object sender, EventArgs e)
        {
            if (sonyaSkillinfo.Text == KlassenSkills.SonyaSkills.wutanstieg)
            {
                sonyaSkillinfo.Text = skilltext;
            }
            else
            {
                sonyaSkillinfo.Text = KlassenSkills.SonyaSkills.wutanstieg;
            }
        }

        private void sonyaSkill4_Click(object sender, EventArgs e)
        {
            if (sonyaSkillinfo.Text == KlassenSkills.SonyaSkills.wuetenderschlag)
            {
                sonyaSkillinfo.Text = skilltext;
            }
            else
            {
                sonyaSkillinfo.Text = KlassenSkills.SonyaSkills.wuetenderschlag;
            }
        }

        private void sonyaSkill7_Click(object sender, EventArgs e)
        {
            if (sonyaSkillinfo.Text == KlassenSkills.SonyaSkills.zerborstenerboden)
            {
                sonyaSkillinfo.Text = skilltext;
            }
            else
            {
                sonyaSkillinfo.Text = KlassenSkills.SonyaSkills.zerborstenerboden;
            }
        }

        private void sonyaSkill10_Click(object sender, EventArgs e)
        {
            if (sonyaSkillinfo.Text == KlassenSkills.SonyaSkills.sprungoffensive)
            {
                sonyaSkillinfo.Text = skilltext;
            }
            else
            {
                sonyaSkillinfo.Text = KlassenSkills.SonyaSkills.sprungoffensive;
            }
        }

        private void sonyaSkill13_Click(object sender, EventArgs e)
        {
            if (sonyaSkillinfo.Text == KlassenSkills.VallaSkills.zauberschild)
            {
                sonyaSkillinfo.Text = skilltext;
            }
            else
            {
                sonyaSkillinfo.Text = KlassenSkills.VallaSkills.zauberschild;
            }
        }

        private void sonyaSkill16_Click(object sender, EventArgs e)
        {
            if (sonyaSkillinfo.Text == KlassenSkills.SonyaSkills.steinhaut)
            {
                sonyaSkillinfo.Text = skilltext;
            }
            else
            {
                sonyaSkillinfo.Text = KlassenSkills.SonyaSkills.steinhaut;
            }
        }

        private void sonyaSkill20_Click(object sender, EventArgs e)
        {
            if (sonyaSkillinfo.Text == KlassenSkills.SonyaSkills.arreatkrater)
            {
                sonyaSkillinfo.Text = skilltext;
            }
            else
            {
                sonyaSkillinfo.Text = KlassenSkills.SonyaSkills.arreatkrater;
            }
        }

        // Sonya Skills Info Ende ---

    }
}
