using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class Conf_Params
    {
        public String ConnectionString { get; set; }
        public bool TF_EXCLUDE_ID_CAL_GPA { get; set; }
        public String TF_EXCLUDE_CAL_GPA_IDS_VALs { get; set; }
        public bool FAC_LAW_SETTING { get; set; }
        public bool FAC_EDU_SETTING { get; set; }
        public bool TF_SHOW_GPA_COL { get; set; }
        public bool TF_SHOW_CGPA_COL { get; set; }
        public bool TF_RATING_ACCORDING_CGPA { get; set; }
        public bool TF_SHOW_PERCENTAGE_COL { get; set; }
        public bool TF_PASS_CONDITION { get; set; }
        public bool TF_SHOW_TOTAL_COL { get; set; }
        public bool TF_PASS_CONDITIONTOT { get; set; }
        public bool TF_RATING_ACCORDING_RATIO { get; set; }
        public bool ShowDays { get; set; }
        public bool FAC_LAW_SETTING_AR { get; set; }
        public int RLValue { get; set; }
        public bool FAC_Tamreed_SETTING_SHAPES { get; set; }
    }
}
