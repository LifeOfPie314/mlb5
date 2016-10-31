using System;
using System.ComponentModel;
using System.Xml.Serialization;

// ReSharper disable InconsistentNaming

namespace Mlb5.Tasks
{

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class boxscore
    {

        private boxscoreLinescore linescoreField;

        private boxscoreUmpire[] umpiresField;

        private boxscoreTeam[] teamField;

        private string windField;

        private string game_typeField;

        private string venue_nameField;

        private string attendanceField;

        private string home_sport_codeField;

        private string official_scorerField;

        private uint game_pkField;

        private string dateField;

        private string status_indField;

        private byte home_league_idField;

        private string elapsed_timeField;

        private string game_idField;

        private byte venue_idField;

        private string start_timeField;

        private string weatherField;

        private string gameday_swField;

        /// <remarks/>
        public boxscoreLinescore linescore
        {
            get
            {
                return linescoreField;
            }
            set
            {
                linescoreField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("umpire", IsNullable = false)]
        public boxscoreUmpire[] umpires
        {
            get
            {
                return umpiresField;
            }
            set
            {
                umpiresField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("team")]
        public boxscoreTeam[] team
        {
            get
            {
                return teamField;
            }
            set
            {
                teamField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string wind
        {
            get
            {
                return windField;
            }
            set
            {
                windField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string game_type
        {
            get
            {
                return game_typeField;
            }
            set
            {
                game_typeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string venue_name
        {
            get
            {
                return venue_nameField;
            }
            set
            {
                venue_nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string attendance
        {
            get
            {
                return attendanceField;
            }
            set
            {
                attendanceField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string home_sport_code
        {
            get
            {
                return home_sport_codeField;
            }
            set
            {
                home_sport_codeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string official_scorer
        {
            get
            {
                return official_scorerField;
            }
            set
            {
                official_scorerField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint game_pk
        {
            get
            {
                return game_pkField;
            }
            set
            {
                game_pkField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string date
        {
            get
            {
                return dateField;
            }
            set
            {
                dateField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string status_ind
        {
            get
            {
                return status_indField;
            }
            set
            {
                status_indField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte home_league_id
        {
            get
            {
                return home_league_idField;
            }
            set
            {
                home_league_idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string elapsed_time
        {
            get
            {
                return elapsed_timeField;
            }
            set
            {
                elapsed_timeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string game_id
        {
            get
            {
                return game_idField;
            }
            set
            {
                game_idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte venue_id
        {
            get
            {
                return venue_idField;
            }
            set
            {
                venue_idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string start_time
        {
            get
            {
                return start_timeField;
            }
            set
            {
                start_timeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string weather
        {
            get
            {
                return weatherField;
            }
            set
            {
                weatherField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string gameday_sw
        {
            get
            {
                return gameday_swField;
            }
            set
            {
                gameday_swField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreLinescore
    {

        private boxscoreLinescoreInning_line_score[] inning_line_scoreField;

        private byte home_team_runsField;

        private byte home_team_errorsField;

        private byte home_team_hitsField;

        private byte away_team_errorsField;

        private byte away_team_runsField;

        private byte away_team_hitsField;

        /// <remarks/>
        [XmlElementAttribute("inning_line_score")]
        public boxscoreLinescoreInning_line_score[] inning_line_score
        {
            get
            {
                return inning_line_scoreField;
            }
            set
            {
                inning_line_scoreField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte home_team_runs
        {
            get
            {
                return home_team_runsField;
            }
            set
            {
                home_team_runsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte home_team_errors
        {
            get
            {
                return home_team_errorsField;
            }
            set
            {
                home_team_errorsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte home_team_hits
        {
            get
            {
                return home_team_hitsField;
            }
            set
            {
                home_team_hitsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte away_team_errors
        {
            get
            {
                return away_team_errorsField;
            }
            set
            {
                away_team_errorsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte away_team_runs
        {
            get
            {
                return away_team_runsField;
            }
            set
            {
                away_team_runsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte away_team_hits
        {
            get
            {
                return away_team_hitsField;
            }
            set
            {
                away_team_hitsField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreLinescoreInning_line_score
    {

        private string homeField;

        private byte awayField;

        private byte inningField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string home
        {
            get
            {
                return homeField;
            }
            set
            {
                homeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte away
        {
            get
            {
                return awayField;
            }
            set
            {
                awayField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte inning
        {
            get
            {
                return inningField;
            }
            set
            {
                inningField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreUmpire
    {

        private uint idField;

        private string positionField;

        private string nameField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return positionField;
            }
            set
            {
                positionField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeam
    {

        private boxscoreTeamPitching pitchingField;

        private boxscoreTeamBatting battingField;

        private boxscoreTeamDouble_play[] double_playField;

        private byte idField;

        private string team_codeField;

        private byte lossesField;

        private string team_flagField;

        private string short_nameField;

        private byte winsField;

        private string full_nameField;

        /// <remarks/>
        public boxscoreTeamPitching pitching
        {
            get
            {
                return pitchingField;
            }
            set
            {
                pitchingField = value;
            }
        }

        /// <remarks/>
        public boxscoreTeamBatting batting
        {
            get
            {
                return battingField;
            }
            set
            {
                battingField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("double_play")]
        public boxscoreTeamDouble_play[] double_play
        {
            get
            {
                return double_playField;
            }
            set
            {
                double_playField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string team_code
        {
            get
            {
                return team_codeField;
            }
            set
            {
                team_codeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte losses
        {
            get
            {
                return lossesField;
            }
            set
            {
                lossesField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string team_flag
        {
            get
            {
                return team_flagField;
            }
            set
            {
                team_flagField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string short_name
        {
            get
            {
                return short_nameField;
            }
            set
            {
                short_nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte wins
        {
            get
            {
                return winsField;
            }
            set
            {
                winsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string full_name
        {
            get
            {
                return full_nameField;
            }
            set
            {
                full_nameField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamPitching
    {

        private boxscoreTeamPitchingPitcher[] pitcherField;

        private byte hrField;

        private decimal bam_eraField;

        private byte soField;

        private byte rField;

        private byte bfField;

        private decimal bis_eraField;

        private byte bbField;

        private byte hField;

        private byte erField;

        private byte outField;

        /// <remarks/>
        [XmlElementAttribute("pitcher")]
        public boxscoreTeamPitchingPitcher[] pitcher
        {
            get
            {
                return pitcherField;
            }
            set
            {
                pitcherField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return hrField;
            }
            set
            {
                hrField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_era
        {
            get
            {
                return bam_eraField;
            }
            set
            {
                bam_eraField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return soField;
            }
            set
            {
                soField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return rField;
            }
            set
            {
                rField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bf
        {
            get
            {
                return bfField;
            }
            set
            {
                bfField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_era
        {
            get
            {
                return bis_eraField;
            }
            set
            {
                bis_eraField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return bbField;
            }
            set
            {
                bbField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return hField;
            }
            set
            {
                hField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte er
        {
            get
            {
                return erField;
            }
            set
            {
                erField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte @out
        {
            get
            {
                return outField;
            }
            set
            {
                outField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamPitchingPitcher
    {

        private object[] itemsField;

        private byte bam_s_erField;

        private byte bam_bsField;

        private byte hrField;

        private byte bam_hldField;

        private byte bis_bsField;

        private byte npField;

        private string name_display_first_lastField;

        private byte game_scoreField;

        private string posField;

        private uint idField;

        private byte bis_lField;

        private byte bam_lField;

        private byte bkField;

        private byte bis_wField;

        private string nameField;

        private byte bfField;

        private decimal bis_eraField;

        private byte bbField;

        private byte bam_s_soField;

        private byte bam_s_bbField;

        private byte bam_wField;

        private byte soField;

        private byte bis_hldField;

        private byte bam_s_rField;

        private byte pitch_orderField;

        private byte hField;

        private byte bis_s_rField;

        private decimal bam_s_ipField;

        private decimal bam_eraField;

        private byte bis_s_soField;

        private byte bis_s_hField;

        private decimal bis_s_ipField;

        private byte bam_s_hField;

        private byte sField;

        private byte aoField;

        private byte bis_svField;

        private byte rField;

        private byte bis_s_erField;

        private byte bam_svField;

        private byte bis_s_bbField;

        private byte erField;

        private byte outField;

        private byte goField;

        private byte irField;

        private bool irFieldSpecified;

        private byte iraField;

        private bool iraFieldSpecified;

        private bool lossField;

        private bool lossFieldSpecified;

        private byte wpField;

        private bool wpFieldSpecified;

        private bool winField;

        private bool winFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute("relief_no_out", typeof(boxscoreTeamPitchingPitcherRelief_no_out))]
        [XmlElementAttribute("strikeout", typeof(boxscoreTeamPitchingPitcherStrikeout))]
        [XmlElementAttribute("walk", typeof(boxscoreTeamPitchingPitcherWalk))]
        public object[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_er
        {
            get
            {
                return bam_s_erField;
            }
            set
            {
                bam_s_erField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_bs
        {
            get
            {
                return bam_bsField;
            }
            set
            {
                bam_bsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return hrField;
            }
            set
            {
                hrField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_hld
        {
            get
            {
                return bam_hldField;
            }
            set
            {
                bam_hldField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_bs
        {
            get
            {
                return bis_bsField;
            }
            set
            {
                bis_bsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte np
        {
            get
            {
                return npField;
            }
            set
            {
                npField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name_display_first_last
        {
            get
            {
                return name_display_first_lastField;
            }
            set
            {
                name_display_first_lastField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte game_score
        {
            get
            {
                return game_scoreField;
            }
            set
            {
                game_scoreField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string pos
        {
            get
            {
                return posField;
            }
            set
            {
                posField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_l
        {
            get
            {
                return bis_lField;
            }
            set
            {
                bis_lField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_l
        {
            get
            {
                return bam_lField;
            }
            set
            {
                bam_lField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bk
        {
            get
            {
                return bkField;
            }
            set
            {
                bkField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_w
        {
            get
            {
                return bis_wField;
            }
            set
            {
                bis_wField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bf
        {
            get
            {
                return bfField;
            }
            set
            {
                bfField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_era
        {
            get
            {
                return bis_eraField;
            }
            set
            {
                bis_eraField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return bbField;
            }
            set
            {
                bbField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_so
        {
            get
            {
                return bam_s_soField;
            }
            set
            {
                bam_s_soField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_bb
        {
            get
            {
                return bam_s_bbField;
            }
            set
            {
                bam_s_bbField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_w
        {
            get
            {
                return bam_wField;
            }
            set
            {
                bam_wField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return soField;
            }
            set
            {
                soField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_hld
        {
            get
            {
                return bis_hldField;
            }
            set
            {
                bis_hldField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_r
        {
            get
            {
                return bam_s_rField;
            }
            set
            {
                bam_s_rField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte pitch_order
        {
            get
            {
                return pitch_orderField;
            }
            set
            {
                pitch_orderField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return hField;
            }
            set
            {
                hField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_r
        {
            get
            {
                return bis_s_rField;
            }
            set
            {
                bis_s_rField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_s_ip
        {
            get
            {
                return bam_s_ipField;
            }
            set
            {
                bam_s_ipField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_era
        {
            get
            {
                return bam_eraField;
            }
            set
            {
                bam_eraField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_so
        {
            get
            {
                return bis_s_soField;
            }
            set
            {
                bis_s_soField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_h
        {
            get
            {
                return bis_s_hField;
            }
            set
            {
                bis_s_hField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_s_ip
        {
            get
            {
                return bis_s_ipField;
            }
            set
            {
                bis_s_ipField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_h
        {
            get
            {
                return bam_s_hField;
            }
            set
            {
                bam_s_hField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte s
        {
            get
            {
                return sField;
            }
            set
            {
                sField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte ao
        {
            get
            {
                return aoField;
            }
            set
            {
                aoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_sv
        {
            get
            {
                return bis_svField;
            }
            set
            {
                bis_svField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return rField;
            }
            set
            {
                rField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_er
        {
            get
            {
                return bis_s_erField;
            }
            set
            {
                bis_s_erField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_sv
        {
            get
            {
                return bam_svField;
            }
            set
            {
                bam_svField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_bb
        {
            get
            {
                return bis_s_bbField;
            }
            set
            {
                bis_s_bbField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte er
        {
            get
            {
                return erField;
            }
            set
            {
                erField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte @out
        {
            get
            {
                return outField;
            }
            set
            {
                outField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte go
        {
            get
            {
                return goField;
            }
            set
            {
                goField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte ir
        {
            get
            {
                return irField;
            }
            set
            {
                irField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool irSpecified
        {
            get
            {
                return irFieldSpecified;
            }
            set
            {
                irFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte ira
        {
            get
            {
                return iraField;
            }
            set
            {
                iraField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool iraSpecified
        {
            get
            {
                return iraFieldSpecified;
            }
            set
            {
                iraFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public bool loss
        {
            get
            {
                return lossField;
            }
            set
            {
                lossField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool lossSpecified
        {
            get
            {
                return lossFieldSpecified;
            }
            set
            {
                lossFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte wp
        {
            get
            {
                return wpField;
            }
            set
            {
                wpField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool wpSpecified
        {
            get
            {
                return wpFieldSpecified;
            }
            set
            {
                wpFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public bool win
        {
            get
            {
                return winField;
            }
            set
            {
                winField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool winSpecified
        {
            get
            {
                return winFieldSpecified;
            }
            set
            {
                winFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamPitchingPitcherRelief_no_out
    {

        private byte inning_numField;

        private ushort eventField;

        private byte batters_facedField;

        private string inningField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte inning_num
        {
            get
            {
                return inning_numField;
            }
            set
            {
                inning_numField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort @event
        {
            get
            {
                return eventField;
            }
            set
            {
                eventField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte batters_faced
        {
            get
            {
                return batters_facedField;
            }
            set
            {
                batters_facedField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string inning
        {
            get
            {
                return inningField;
            }
            set
            {
                inningField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamPitchingPitcherStrikeout
    {

        private ushort eventField;

        private uint batter_idField;

        private string batter_nameField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort @event
        {
            get
            {
                return eventField;
            }
            set
            {
                eventField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint batter_id
        {
            get
            {
                return batter_idField;
            }
            set
            {
                batter_idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string batter_name
        {
            get
            {
                return batter_nameField;
            }
            set
            {
                batter_nameField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamPitchingPitcherWalk
    {

        private ushort eventField;

        private uint batter_idField;

        private string batter_nameField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort @event
        {
            get
            {
                return eventField;
            }
            set
            {
                eventField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint batter_id
        {
            get
            {
                return batter_idField;
            }
            set
            {
                batter_idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string batter_name
        {
            get
            {
                return batter_nameField;
            }
            set
            {
                batter_nameField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamBatting
    {

        private boxscoreTeamBattingBatter[] batterField;

        private byte hrField;

        private byte dField;

        private decimal bam_obpField;

        private byte ab_rispField;

        private byte soField;

        private decimal bis_obpField;

        private byte aField;

        private decimal bis_opsField;

        private decimal bam_opsField;

        private decimal bis_slgField;

        private byte t_lobField;

        private byte hField;

        private byte rbiField;

        private decimal bis_avgField;

        private byte lobField;

        private byte tField;

        private byte rField;

        private decimal bam_slgField;

        private byte poField;

        private byte abField;

        private byte bbField;

        private byte h_rispField;

        private decimal bam_avgField;

        /// <remarks/>
        [XmlElementAttribute("batter")]
        public boxscoreTeamBattingBatter[] batter
        {
            get
            {
                return batterField;
            }
            set
            {
                batterField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return hrField;
            }
            set
            {
                hrField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte d
        {
            get
            {
                return dField;
            }
            set
            {
                dField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_obp
        {
            get
            {
                return bam_obpField;
            }
            set
            {
                bam_obpField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte ab_risp
        {
            get
            {
                return ab_rispField;
            }
            set
            {
                ab_rispField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return soField;
            }
            set
            {
                soField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_obp
        {
            get
            {
                return bis_obpField;
            }
            set
            {
                bis_obpField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte a
        {
            get
            {
                return aField;
            }
            set
            {
                aField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_ops
        {
            get
            {
                return bis_opsField;
            }
            set
            {
                bis_opsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_ops
        {
            get
            {
                return bam_opsField;
            }
            set
            {
                bam_opsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_slg
        {
            get
            {
                return bis_slgField;
            }
            set
            {
                bis_slgField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte t_lob
        {
            get
            {
                return t_lobField;
            }
            set
            {
                t_lobField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return hField;
            }
            set
            {
                hField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return rbiField;
            }
            set
            {
                rbiField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_avg
        {
            get
            {
                return bis_avgField;
            }
            set
            {
                bis_avgField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte lob
        {
            get
            {
                return lobField;
            }
            set
            {
                lobField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte t
        {
            get
            {
                return tField;
            }
            set
            {
                tField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return rField;
            }
            set
            {
                rField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_slg
        {
            get
            {
                return bam_slgField;
            }
            set
            {
                bam_slgField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte po
        {
            get
            {
                return poField;
            }
            set
            {
                poField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return abField;
            }
            set
            {
                abField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return bbField;
            }
            set
            {
                bbField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte h_risp
        {
            get
            {
                return h_rispField;
            }
            set
            {
                h_rispField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_avg
        {
            get
            {
                return bam_avgField;
            }
            set
            {
                bam_avgField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamBattingBatter
    {

        private boxscoreTeamBattingBatterDouble[] doubleField;

        private boxscoreTeamBattingBatterStolen_base stolen_baseField;

        private boxscoreTeamBattingBatterPinch_hit pinch_hitField;

        private boxscoreTeamBattingBatterPickoff pickoffField;

        private byte sacField;

        private decimal bis_obpField;

        private string name_display_first_lastField;

        private string posField;

        private decimal bis_avgField;

        private byte tbField;

        private bool tbFieldSpecified;

        private byte bbField;

        private decimal fldgField;

        private byte bam_s_soField;

        private byte bis_s_hrField;

        private byte bam_s_bbField;

        private byte hbpField;

        private decimal bam_obpField;

        private byte soField;

        private byte sfField;

        private ushort bat_orderField;

        private byte bis_s_csField;

        private bool bis_s_csFieldSpecified;

        private byte bis_s_soField;

        private byte sbField;

        private decimal bam_slgField;

        private byte poField;

        private decimal bam_avgField;

        private byte pkField;

        private bool pkFieldSpecified;

        private byte hrField;

        private decimal bis_opsField;

        private decimal bam_opsField;

        private decimal bis_slgField;

        private byte bam_s_csField;

        private bool bam_s_csFieldSpecified;

        private uint idField;

        private byte rbiField;

        private byte lobField;

        private string nameField;

        private byte dField;

        private byte eField;

        private byte aField;

        private byte bam_s_hrField;

        private byte bam_s_rField;

        private byte hField;

        private byte bis_s_rField;

        private byte bis_s_rbiField;

        private byte tField;

        private byte bis_s_hField;

        private byte aoField;

        private byte bam_s_hField;

        private byte rField;

        private byte bam_s_rbiField;

        private byte bam_s_eField;

        private bool bam_s_eFieldSpecified;

        private byte bis_s_dField;

        private bool bis_s_dFieldSpecified;

        private byte bam_s_dField;

        private bool bam_s_dFieldSpecified;

        private byte abField;

        private byte bis_s_eField;

        private bool bis_s_eFieldSpecified;

        private byte bis_s_bbField;

        private byte gidpField;

        private bool gidpFieldSpecified;

        private byte bam_s_sbField;

        private bool bam_s_sbFieldSpecified;

        private byte bis_s_sbField;

        private bool bis_s_sbFieldSpecified;

        private byte goField;

        private bool goFieldSpecified;

        private ushort first_gidpField;

        private bool first_gidpFieldSpecified;

        private string noteField;

        private byte bis_s_tField;

        private bool bis_s_tFieldSpecified;

        private byte bam_s_tField;

        private bool bam_s_tFieldSpecified;

        private byte bis_s_pbField;

        private bool bis_s_pbFieldSpecified;

        private byte bam_s_pbField;

        private bool bam_s_pbFieldSpecified;

        private ushort first_two_out_risp_lobField;

        private bool first_two_out_risp_lobFieldSpecified;

        private byte two_out_risp_lobField;

        private bool two_out_risp_lobFieldSpecified;

        private byte pk_fldgField;

        private bool pk_fldgFieldSpecified;

        private byte first_rbiField;

        private bool first_rbiFieldSpecified;

        private byte first_two_out_rbiField;

        private bool first_two_out_rbiFieldSpecified;

        private byte two_out_rbiField;

        private bool two_out_rbiFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute("double")]
        public boxscoreTeamBattingBatterDouble[] @double
        {
            get
            {
                return doubleField;
            }
            set
            {
                doubleField = value;
            }
        }

        /// <remarks/>
        public boxscoreTeamBattingBatterStolen_base stolen_base
        {
            get
            {
                return stolen_baseField;
            }
            set
            {
                stolen_baseField = value;
            }
        }

        /// <remarks/>
        public boxscoreTeamBattingBatterPinch_hit pinch_hit
        {
            get
            {
                return pinch_hitField;
            }
            set
            {
                pinch_hitField = value;
            }
        }

        /// <remarks/>
        public boxscoreTeamBattingBatterPickoff pickoff
        {
            get
            {
                return pickoffField;
            }
            set
            {
                pickoffField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte sac
        {
            get
            {
                return sacField;
            }
            set
            {
                sacField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_obp
        {
            get
            {
                return bis_obpField;
            }
            set
            {
                bis_obpField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name_display_first_last
        {
            get
            {
                return name_display_first_lastField;
            }
            set
            {
                name_display_first_lastField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string pos
        {
            get
            {
                return posField;
            }
            set
            {
                posField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_avg
        {
            get
            {
                return bis_avgField;
            }
            set
            {
                bis_avgField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte tb
        {
            get
            {
                return tbField;
            }
            set
            {
                tbField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool tbSpecified
        {
            get
            {
                return tbFieldSpecified;
            }
            set
            {
                tbFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bb
        {
            get
            {
                return bbField;
            }
            set
            {
                bbField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal fldg
        {
            get
            {
                return fldgField;
            }
            set
            {
                fldgField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_so
        {
            get
            {
                return bam_s_soField;
            }
            set
            {
                bam_s_soField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_hr
        {
            get
            {
                return bis_s_hrField;
            }
            set
            {
                bis_s_hrField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_bb
        {
            get
            {
                return bam_s_bbField;
            }
            set
            {
                bam_s_bbField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte hbp
        {
            get
            {
                return hbpField;
            }
            set
            {
                hbpField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_obp
        {
            get
            {
                return bam_obpField;
            }
            set
            {
                bam_obpField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte so
        {
            get
            {
                return soField;
            }
            set
            {
                soField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte sf
        {
            get
            {
                return sfField;
            }
            set
            {
                sfField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort bat_order
        {
            get
            {
                return bat_orderField;
            }
            set
            {
                bat_orderField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_cs
        {
            get
            {
                return bis_s_csField;
            }
            set
            {
                bis_s_csField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bis_s_csSpecified
        {
            get
            {
                return bis_s_csFieldSpecified;
            }
            set
            {
                bis_s_csFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_so
        {
            get
            {
                return bis_s_soField;
            }
            set
            {
                bis_s_soField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte sb
        {
            get
            {
                return sbField;
            }
            set
            {
                sbField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_slg
        {
            get
            {
                return bam_slgField;
            }
            set
            {
                bam_slgField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte po
        {
            get
            {
                return poField;
            }
            set
            {
                poField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_avg
        {
            get
            {
                return bam_avgField;
            }
            set
            {
                bam_avgField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte pk
        {
            get
            {
                return pkField;
            }
            set
            {
                pkField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool pkSpecified
        {
            get
            {
                return pkFieldSpecified;
            }
            set
            {
                pkFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte hr
        {
            get
            {
                return hrField;
            }
            set
            {
                hrField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_ops
        {
            get
            {
                return bis_opsField;
            }
            set
            {
                bis_opsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bam_ops
        {
            get
            {
                return bam_opsField;
            }
            set
            {
                bam_opsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal bis_slg
        {
            get
            {
                return bis_slgField;
            }
            set
            {
                bis_slgField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_cs
        {
            get
            {
                return bam_s_csField;
            }
            set
            {
                bam_s_csField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bam_s_csSpecified
        {
            get
            {
                return bam_s_csFieldSpecified;
            }
            set
            {
                bam_s_csFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte rbi
        {
            get
            {
                return rbiField;
            }
            set
            {
                rbiField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte lob
        {
            get
            {
                return lobField;
            }
            set
            {
                lobField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte d
        {
            get
            {
                return dField;
            }
            set
            {
                dField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte e
        {
            get
            {
                return eField;
            }
            set
            {
                eField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte a
        {
            get
            {
                return aField;
            }
            set
            {
                aField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_hr
        {
            get
            {
                return bam_s_hrField;
            }
            set
            {
                bam_s_hrField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_r
        {
            get
            {
                return bam_s_rField;
            }
            set
            {
                bam_s_rField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte h
        {
            get
            {
                return hField;
            }
            set
            {
                hField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_r
        {
            get
            {
                return bis_s_rField;
            }
            set
            {
                bis_s_rField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_rbi
        {
            get
            {
                return bis_s_rbiField;
            }
            set
            {
                bis_s_rbiField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte t
        {
            get
            {
                return tField;
            }
            set
            {
                tField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_h
        {
            get
            {
                return bis_s_hField;
            }
            set
            {
                bis_s_hField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte ao
        {
            get
            {
                return aoField;
            }
            set
            {
                aoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_h
        {
            get
            {
                return bam_s_hField;
            }
            set
            {
                bam_s_hField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return rField;
            }
            set
            {
                rField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_rbi
        {
            get
            {
                return bam_s_rbiField;
            }
            set
            {
                bam_s_rbiField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_e
        {
            get
            {
                return bam_s_eField;
            }
            set
            {
                bam_s_eField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bam_s_eSpecified
        {
            get
            {
                return bam_s_eFieldSpecified;
            }
            set
            {
                bam_s_eFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_d
        {
            get
            {
                return bis_s_dField;
            }
            set
            {
                bis_s_dField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bis_s_dSpecified
        {
            get
            {
                return bis_s_dFieldSpecified;
            }
            set
            {
                bis_s_dFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_d
        {
            get
            {
                return bam_s_dField;
            }
            set
            {
                bam_s_dField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bam_s_dSpecified
        {
            get
            {
                return bam_s_dFieldSpecified;
            }
            set
            {
                bam_s_dFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte ab
        {
            get
            {
                return abField;
            }
            set
            {
                abField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_e
        {
            get
            {
                return bis_s_eField;
            }
            set
            {
                bis_s_eField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bis_s_eSpecified
        {
            get
            {
                return bis_s_eFieldSpecified;
            }
            set
            {
                bis_s_eFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_bb
        {
            get
            {
                return bis_s_bbField;
            }
            set
            {
                bis_s_bbField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte gidp
        {
            get
            {
                return gidpField;
            }
            set
            {
                gidpField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool gidpSpecified
        {
            get
            {
                return gidpFieldSpecified;
            }
            set
            {
                gidpFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_sb
        {
            get
            {
                return bam_s_sbField;
            }
            set
            {
                bam_s_sbField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bam_s_sbSpecified
        {
            get
            {
                return bam_s_sbFieldSpecified;
            }
            set
            {
                bam_s_sbFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_sb
        {
            get
            {
                return bis_s_sbField;
            }
            set
            {
                bis_s_sbField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bis_s_sbSpecified
        {
            get
            {
                return bis_s_sbFieldSpecified;
            }
            set
            {
                bis_s_sbFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte go
        {
            get
            {
                return goField;
            }
            set
            {
                goField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool goSpecified
        {
            get
            {
                return goFieldSpecified;
            }
            set
            {
                goFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort first_gidp
        {
            get
            {
                return first_gidpField;
            }
            set
            {
                first_gidpField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool first_gidpSpecified
        {
            get
            {
                return first_gidpFieldSpecified;
            }
            set
            {
                first_gidpFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string note
        {
            get
            {
                return noteField;
            }
            set
            {
                noteField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_t
        {
            get
            {
                return bis_s_tField;
            }
            set
            {
                bis_s_tField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bis_s_tSpecified
        {
            get
            {
                return bis_s_tFieldSpecified;
            }
            set
            {
                bis_s_tFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_t
        {
            get
            {
                return bam_s_tField;
            }
            set
            {
                bam_s_tField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bam_s_tSpecified
        {
            get
            {
                return bam_s_tFieldSpecified;
            }
            set
            {
                bam_s_tFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bis_s_pb
        {
            get
            {
                return bis_s_pbField;
            }
            set
            {
                bis_s_pbField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bis_s_pbSpecified
        {
            get
            {
                return bis_s_pbFieldSpecified;
            }
            set
            {
                bis_s_pbFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte bam_s_pb
        {
            get
            {
                return bam_s_pbField;
            }
            set
            {
                bam_s_pbField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool bam_s_pbSpecified
        {
            get
            {
                return bam_s_pbFieldSpecified;
            }
            set
            {
                bam_s_pbFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort first_two_out_risp_lob
        {
            get
            {
                return first_two_out_risp_lobField;
            }
            set
            {
                first_two_out_risp_lobField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool first_two_out_risp_lobSpecified
        {
            get
            {
                return first_two_out_risp_lobFieldSpecified;
            }
            set
            {
                first_two_out_risp_lobFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte two_out_risp_lob
        {
            get
            {
                return two_out_risp_lobField;
            }
            set
            {
                two_out_risp_lobField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool two_out_risp_lobSpecified
        {
            get
            {
                return two_out_risp_lobFieldSpecified;
            }
            set
            {
                two_out_risp_lobFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte pk_fldg
        {
            get
            {
                return pk_fldgField;
            }
            set
            {
                pk_fldgField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool pk_fldgSpecified
        {
            get
            {
                return pk_fldgFieldSpecified;
            }
            set
            {
                pk_fldgFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte first_rbi
        {
            get
            {
                return first_rbiField;
            }
            set
            {
                first_rbiField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool first_rbiSpecified
        {
            get
            {
                return first_rbiFieldSpecified;
            }
            set
            {
                first_rbiFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte first_two_out_rbi
        {
            get
            {
                return first_two_out_rbiField;
            }
            set
            {
                first_two_out_rbiField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool first_two_out_rbiSpecified
        {
            get
            {
                return first_two_out_rbiFieldSpecified;
            }
            set
            {
                first_two_out_rbiFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte two_out_rbi
        {
            get
            {
                return two_out_rbiField;
            }
            set
            {
                two_out_rbiField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool two_out_rbiSpecified
        {
            get
            {
                return two_out_rbiFieldSpecified;
            }
            set
            {
                two_out_rbiFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamBattingBatterDouble
    {

        private string pitcher_nameField;

        private byte eventField;

        private uint pitcher_idField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string pitcher_name
        {
            get
            {
                return pitcher_nameField;
            }
            set
            {
                pitcher_nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte @event
        {
            get
            {
                return eventField;
            }
            set
            {
                eventField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint pitcher_id
        {
            get
            {
                return pitcher_idField;
            }
            set
            {
                pitcher_idField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamBattingBatterStolen_base
    {

        private byte map_orderField;

        private byte base_numField;

        private string pitcher_nameField;

        private string catcher_nameField;

        private ushort eventField;

        private string baseField;

        private uint pitcher_idField;

        private uint catcher_idField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte map_order
        {
            get
            {
                return map_orderField;
            }
            set
            {
                map_orderField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte base_num
        {
            get
            {
                return base_numField;
            }
            set
            {
                base_numField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string pitcher_name
        {
            get
            {
                return pitcher_nameField;
            }
            set
            {
                pitcher_nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string catcher_name
        {
            get
            {
                return catcher_nameField;
            }
            set
            {
                catcher_nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort @event
        {
            get
            {
                return eventField;
            }
            set
            {
                eventField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string @base
        {
            get
            {
                return baseField;
            }
            set
            {
                baseField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint pitcher_id
        {
            get
            {
                return pitcher_idField;
            }
            set
            {
                pitcher_idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint catcher_id
        {
            get
            {
                return catcher_idField;
            }
            set
            {
                catcher_idField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamBattingBatterPinch_hit
    {

        private string replaced_nameField;

        private byte inning_numField;

        private string resultField;

        private uint replaced_idField;

        private ushort eventField;

        private string sequenceField;

        private string inningField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string replaced_name
        {
            get
            {
                return replaced_nameField;
            }
            set
            {
                replaced_nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte inning_num
        {
            get
            {
                return inning_numField;
            }
            set
            {
                inning_numField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string result
        {
            get
            {
                return resultField;
            }
            set
            {
                resultField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint replaced_id
        {
            get
            {
                return replaced_idField;
            }
            set
            {
                replaced_idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort @event
        {
            get
            {
                return eventField;
            }
            set
            {
                eventField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string sequence
        {
            get
            {
                return sequenceField;
            }
            set
            {
                sequenceField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string inning
        {
            get
            {
                return inningField;
            }
            set
            {
                inningField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamBattingBatterPickoff
    {

        private byte map_orderField;

        private bool map_orderFieldSpecified;

        private byte base_numField;

        private uint fielder_idField;

        private bool fielder_idFieldSpecified;

        private ushort eventField;

        private string baseField;

        private string fielder_nameField;

        private string typeField;

        private string runner_nameField;

        private uint runner_idField;

        private bool runner_idFieldSpecified;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte map_order
        {
            get
            {
                return map_orderField;
            }
            set
            {
                map_orderField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool map_orderSpecified
        {
            get
            {
                return map_orderFieldSpecified;
            }
            set
            {
                map_orderFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte base_num
        {
            get
            {
                return base_numField;
            }
            set
            {
                base_numField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint fielder_id
        {
            get
            {
                return fielder_idField;
            }
            set
            {
                fielder_idField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool fielder_idSpecified
        {
            get
            {
                return fielder_idFieldSpecified;
            }
            set
            {
                fielder_idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort @event
        {
            get
            {
                return eventField;
            }
            set
            {
                eventField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string @base
        {
            get
            {
                return baseField;
            }
            set
            {
                baseField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string fielder_name
        {
            get
            {
                return fielder_nameField;
            }
            set
            {
                fielder_nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return typeField;
            }
            set
            {
                typeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string runner_name
        {
            get
            {
                return runner_nameField;
            }
            set
            {
                runner_nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint runner_id
        {
            get
            {
                return runner_idField;
            }
            set
            {
                runner_idField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool runner_idSpecified
        {
            get
            {
                return runner_idFieldSpecified;
            }
            set
            {
                runner_idFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class boxscoreTeamDouble_play
    {

        private ushort eventField;

        private string id_sequenceField;

        private string name_sequenceField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort @event
        {
            get
            {
                return eventField;
            }
            set
            {
                eventField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string id_sequence
        {
            get
            {
                return id_sequenceField;
            }
            set
            {
                id_sequenceField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name_sequence
        {
            get
            {
                return name_sequenceField;
            }
            set
            {
                name_sequenceField = value;
            }
        }
    }



    public class GameClass
    {
    }
}