using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace PivotController.Controllers
{
    public class DataSource
    {
        public class PivotViewData
        {
            public double norm_hours { get; set; }
            public string norm_activity_category_name { get; set; }
            public string norm_activity_name { get; set; }
            public string norm_activity_unit_type_name { get; set; }
            public string norm_activity_classification_name { get; set; }
            public double hours { get; set; }
            // public string user_id { get; set; }
            public string user_fullname { get; set; }
            public double user_bank { get; set; }
            public string user_auid { get; set; }
            public bool user_active { get; set; }
            public double user_balance { get; set; }
            public string user_firstname { get; set; }
            public string user_section_name { get; set; }
            public string user_title_capacity { get; set; }
            public string user_title_name { get; set; }
            public string user_lastname { get; set; }
            public string course_department_name { get; set; }
            // public string course_id { get; set; }
            public string course_programme_name { get; set; }
            public string course_language { get; set; }
            // public string course_term_id { get; set; }
            public string course_term_name { get; set; }
            public int course_ects { get; set; }
            public string course_uva { get; set; }
            public int course_year_year { get; set; }
            // public string course_year_id { get; set; }
            public string course_name { get; set; }
            public double units { get; set; }
            public string year_term { get; set; }
            public int year { get; set; }
        }
    }
}
