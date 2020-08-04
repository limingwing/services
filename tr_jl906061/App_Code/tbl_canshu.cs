using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
 
 
    /// <summary>
    /// 类tbl_canshu。
    /// </summary>
    [Serializable]
    public partial class tbl_canshu
    {
        public tbl_canshu()
        { }
        #region Model
        private int _id;
        private string _sys_name;
        private string _canshu_gonggao;
        private int? _reg_shoping = 0;
        private decimal? _canshu_001 = 0M;
        private decimal? _canshu_002 = 0M;
        private decimal? _canshu_003 = 0M;
        private decimal? _canshu_004 = 0M;
        private decimal? _canshu_005;
        private decimal? _canshu_006 = 0M;
        private decimal? _canshu_007 = 0M;
        private decimal? _canshu_008 = 0M;
        private decimal? _canshu_009 = 0M;
        private decimal? _canshu_010 = 0M;
        private decimal? _canshu_011 = 0M;
        private decimal? _canshu_012 = 0M;
        private decimal? _canshu_013 = 0M;
        private decimal? _canshu_014 = 0M;
        private decimal? _canshu_015 = 0M;
        private decimal? _canshu_016 = 0M;
        private decimal? _canshu_017 = 0M;
        private decimal? _canshu_018 = 0M;
        private decimal? _canshu_019 = 0M;
        private decimal? _canshu_020 = 0M;
        private decimal? _canshu_021 = 0M;
        private decimal? _canshu_022 = 0M;
        private decimal? _canshu_023 = 0M;
        private decimal? _canshu_024 = 0M;
        private decimal? _canshu_025 = 0M;
        private decimal? _canshu_026 = 0M;
        private decimal? _canshu_027 = 0M;
        private decimal? _canshu_028 = 0M;
        private decimal? _canshu_029 = 0M;
        private decimal? _canshu_030 = 0M;
        private decimal? _canshu_031 = 0M;
        private decimal? _canshu_032 = 0M;
        private decimal? _canshu_033 = 0M;
        private decimal? _canshu_034 = 0M;
        private decimal? _canshu_035 = 0M;
        private decimal? _canshu_036 = 0M;
        private decimal? _canshu_037 = 0M;
        private decimal? _canshu_038 = 0M;
        private decimal? _canshu_039 = 0M;
        private decimal? _canshu_040 = 0M;
        private decimal? _canshu_041 = 0M;
        private decimal? _canshu_042 = 0M;
        private decimal? _canshu_043 = 0M;
        private decimal? _canshu_044 = 0M;
        private decimal? _canshu_045 = 0M;
        private decimal? _canshu_046 = 0M;
        private decimal? _canshu_047 = 0M;
        private decimal? _canshu_048 = 0M;
        private decimal? _canshu_049 = 0M;
        private decimal? _canshu_050 = 0M;
        private decimal? _canshu_051 = 0M;
        private decimal? _canshu_052 = 0M;
        private decimal? _canshu_053 = 0M;
        private decimal? _canshu_054 = 0M;
        private decimal? _canshu_055 = 0M;
        private decimal? _canshu_056 = 0M;
        private decimal? _canshu_057 = 0M;
        private decimal? _canshu_058 = 0M;
        private decimal? _canshu_059 = 0M;
        private decimal? _canshu_060 = 0M;
        private decimal? _canshu_061 = 0M;
        private decimal? _canshu_062 = 0M;
        private decimal? _canshu_063 = 0M;
        private decimal? _canshu_064 = 0M;
        private decimal? _canshu_065 = 0M;
        private decimal? _canshu_066;
        private decimal? _canshu_067;
        private decimal? _canshu_068;
        private decimal? _canshu_069;
        private decimal? _canshu_070;
        private decimal? _canshu_071;
        private decimal? _canshu_072;
        private decimal? _canshu_073;
        private decimal? _canshu_074;
        private decimal? _canshu_075;
        private decimal? _canshu_076;
        private decimal? _canshu_077;
        private decimal? _canshu_078;
        private decimal? _canshu_079;
        private decimal? _canshu_080;
        private decimal? _canshu_081;
        private decimal? _canshu_082;
        private decimal? _canshu_083;
        private decimal? _canshu_084;
        private decimal? _canshu_085;
        private decimal? _canshu_086;
        private decimal? _canshu_087;
        private decimal? _canshu_088;
        private decimal? _canshu_089;
        private decimal? _canshu_090;
        private decimal? _canshu_091;
        private decimal? _canshu_092;
        private decimal? _canshu_093;
        private decimal? _canshu_094;
        private decimal? _canshu_095;
        private decimal? _canshu_096;
        private decimal? _canshu_097;
        private decimal? _canshu_098;
        private decimal? _canshu_099;
        private decimal? _canshu_100;
        private decimal? _tikuan_sx;
        private decimal? _tikuan_di;
        private int? _jiesuan_flag = 0;
        private DateTime? _dispose_time;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string canshu_gonggao
        {
            set { _canshu_gonggao = value; }
            get { return _canshu_gonggao; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string sys_name
        {
            set { _sys_name = value; }
            get { return _sys_name; }
        }
        /// <summary>
        /// 注册是否购买产品（请不要删除该字段）
        /// </summary>
        public int? reg_shoping
        {
            set { _reg_shoping = value; }
            get { return _reg_shoping; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_001
        {
            set { _canshu_001 = value; }
            get { return _canshu_001; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_002
        {
            set { _canshu_002 = value; }
            get { return _canshu_002; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_003
        {
            set { _canshu_003 = value; }
            get { return _canshu_003; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_004
        {
            set { _canshu_004 = value; }
            get { return _canshu_004; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_005
        {
            set { _canshu_005 = value; }
            get { return _canshu_005; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_006
        {
            set { _canshu_006 = value; }
            get { return _canshu_006; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_007
        {
            set { _canshu_007 = value; }
            get { return _canshu_007; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_008
        {
            set { _canshu_008 = value; }
            get { return _canshu_008; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_009
        {
            set { _canshu_009 = value; }
            get { return _canshu_009; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_010
        {
            set { _canshu_010 = value; }
            get { return _canshu_010; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_011
        {
            set { _canshu_011 = value; }
            get { return _canshu_011; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_012
        {
            set { _canshu_012 = value; }
            get { return _canshu_012; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_013
        {
            set { _canshu_013 = value; }
            get { return _canshu_013; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_014
        {
            set { _canshu_014 = value; }
            get { return _canshu_014; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_015
        {
            set { _canshu_015 = value; }
            get { return _canshu_015; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_016
        {
            set { _canshu_016 = value; }
            get { return _canshu_016; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_017
        {
            set { _canshu_017 = value; }
            get { return _canshu_017; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_018
        {
            set { _canshu_018 = value; }
            get { return _canshu_018; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_019
        {
            set { _canshu_019 = value; }
            get { return _canshu_019; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_020
        {
            set { _canshu_020 = value; }
            get { return _canshu_020; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_021
        {
            set { _canshu_021 = value; }
            get { return _canshu_021; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_022
        {
            set { _canshu_022 = value; }
            get { return _canshu_022; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_023
        {
            set { _canshu_023 = value; }
            get { return _canshu_023; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_024
        {
            set { _canshu_024 = value; }
            get { return _canshu_024; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_025
        {
            set { _canshu_025 = value; }
            get { return _canshu_025; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_026
        {
            set { _canshu_026 = value; }
            get { return _canshu_026; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_027
        {
            set { _canshu_027 = value; }
            get { return _canshu_027; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_028
        {
            set { _canshu_028 = value; }
            get { return _canshu_028; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_029
        {
            set { _canshu_029 = value; }
            get { return _canshu_029; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_030
        {
            set { _canshu_030 = value; }
            get { return _canshu_030; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_031
        {
            set { _canshu_031 = value; }
            get { return _canshu_031; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_032
        {
            set { _canshu_032 = value; }
            get { return _canshu_032; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_033
        {
            set { _canshu_033 = value; }
            get { return _canshu_033; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_034
        {
            set { _canshu_034 = value; }
            get { return _canshu_034; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_035
        {
            set { _canshu_035 = value; }
            get { return _canshu_035; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_036
        {
            set { _canshu_036 = value; }
            get { return _canshu_036; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_037
        {
            set { _canshu_037 = value; }
            get { return _canshu_037; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_038
        {
            set { _canshu_038 = value; }
            get { return _canshu_038; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_039
        {
            set { _canshu_039 = value; }
            get { return _canshu_039; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_040
        {
            set { _canshu_040 = value; }
            get { return _canshu_040; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_041
        {
            set { _canshu_041 = value; }
            get { return _canshu_041; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_042
        {
            set { _canshu_042 = value; }
            get { return _canshu_042; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_043
        {
            set { _canshu_043 = value; }
            get { return _canshu_043; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_044
        {
            set { _canshu_044 = value; }
            get { return _canshu_044; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_045
        {
            set { _canshu_045 = value; }
            get { return _canshu_045; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_046
        {
            set { _canshu_046 = value; }
            get { return _canshu_046; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_047
        {
            set { _canshu_047 = value; }
            get { return _canshu_047; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_048
        {
            set { _canshu_048 = value; }
            get { return _canshu_048; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_049
        {
            set { _canshu_049 = value; }
            get { return _canshu_049; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_050
        {
            set { _canshu_050 = value; }
            get { return _canshu_050; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_051
        {
            set { _canshu_051 = value; }
            get { return _canshu_051; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_052
        {
            set { _canshu_052 = value; }
            get { return _canshu_052; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_053
        {
            set { _canshu_053 = value; }
            get { return _canshu_053; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_054
        {
            set { _canshu_054 = value; }
            get { return _canshu_054; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_055
        {
            set { _canshu_055 = value; }
            get { return _canshu_055; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_056
        {
            set { _canshu_056 = value; }
            get { return _canshu_056; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_057
        {
            set { _canshu_057 = value; }
            get { return _canshu_057; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_058
        {
            set { _canshu_058 = value; }
            get { return _canshu_058; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_059
        {
            set { _canshu_059 = value; }
            get { return _canshu_059; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_060
        {
            set { _canshu_060 = value; }
            get { return _canshu_060; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_061
        {
            set { _canshu_061 = value; }
            get { return _canshu_061; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_062
        {
            set { _canshu_062 = value; }
            get { return _canshu_062; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_063
        {
            set { _canshu_063 = value; }
            get { return _canshu_063; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_064
        {
            set { _canshu_064 = value; }
            get { return _canshu_064; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_065
        {
            set { _canshu_065 = value; }
            get { return _canshu_065; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_066
        {
            set { _canshu_066 = value; }
            get { return _canshu_066; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_067
        {
            set { _canshu_067 = value; }
            get { return _canshu_067; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_068
        {
            set { _canshu_068 = value; }
            get { return _canshu_068; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_069
        {
            set { _canshu_069 = value; }
            get { return _canshu_069; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_070
        {
            set { _canshu_070 = value; }
            get { return _canshu_070; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_071
        {
            set { _canshu_071 = value; }
            get { return _canshu_071; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_072
        {
            set { _canshu_072 = value; }
            get { return _canshu_072; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_073
        {
            set { _canshu_073 = value; }
            get { return _canshu_073; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_074
        {
            set { _canshu_074 = value; }
            get { return _canshu_074; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_075
        {
            set { _canshu_075 = value; }
            get { return _canshu_075; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_076
        {
            set { _canshu_076 = value; }
            get { return _canshu_076; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_077
        {
            set { _canshu_077 = value; }
            get { return _canshu_077; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_078
        {
            set { _canshu_078 = value; }
            get { return _canshu_078; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_079
        {
            set { _canshu_079 = value; }
            get { return _canshu_079; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_080
        {
            set { _canshu_080 = value; }
            get { return _canshu_080; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_081
        {
            set { _canshu_081 = value; }
            get { return _canshu_081; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_082
        {
            set { _canshu_082 = value; }
            get { return _canshu_082; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_083
        {
            set { _canshu_083 = value; }
            get { return _canshu_083; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_084
        {
            set { _canshu_084 = value; }
            get { return _canshu_084; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_085
        {
            set { _canshu_085 = value; }
            get { return _canshu_085; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_086
        {
            set { _canshu_086 = value; }
            get { return _canshu_086; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_087
        {
            set { _canshu_087 = value; }
            get { return _canshu_087; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_088
        {
            set { _canshu_088 = value; }
            get { return _canshu_088; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_089
        {
            set { _canshu_089 = value; }
            get { return _canshu_089; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_090
        {
            set { _canshu_090 = value; }
            get { return _canshu_090; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_091
        {
            set { _canshu_091 = value; }
            get { return _canshu_091; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_092
        {
            set { _canshu_092 = value; }
            get { return _canshu_092; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_093
        {
            set { _canshu_093 = value; }
            get { return _canshu_093; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_094
        {
            set { _canshu_094 = value; }
            get { return _canshu_094; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_095
        {
            set { _canshu_095 = value; }
            get { return _canshu_095; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_096
        {
            set { _canshu_096 = value; }
            get { return _canshu_096; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_097
        {
            set { _canshu_097 = value; }
            get { return _canshu_097; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_098
        {
            set { _canshu_098 = value; }
            get { return _canshu_098; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_099
        {
            set { _canshu_099 = value; }
            get { return _canshu_099; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? canshu_100
        {
            set { _canshu_100 = value; }
            get { return _canshu_100; }
        }
        /// <summary>
        /// 提现手续费
        /// </summary>
        public decimal? tikuan_sx
        {
            set { _tikuan_sx = value; }
            get { return _tikuan_sx; }
        }
        /// <summary>
        /// 提现最低金额
        /// </summary>
        public decimal? tikuan_di
        {
            set { _tikuan_di = value; }
            get { return _tikuan_di; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? jiesuan_flag
        {
            set { _jiesuan_flag = value; }
            get { return _jiesuan_flag; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? dispose_time
        {
            set { _dispose_time = value; }
            get { return _dispose_time; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tbl_canshu(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,canshu_gonggao,sys_name,reg_shoping,canshu_001,canshu_002,canshu_003,canshu_004,canshu_005,canshu_006,canshu_007,canshu_008,canshu_009,canshu_010,canshu_011,canshu_012,canshu_013,canshu_014,canshu_015,canshu_016,canshu_017,canshu_018,canshu_019,canshu_020,canshu_021,canshu_022,canshu_023,canshu_024,canshu_025,canshu_026,canshu_027,canshu_028,canshu_029,canshu_030,canshu_031,canshu_032,canshu_033,canshu_034,canshu_035,canshu_036,canshu_037,canshu_038,canshu_039,canshu_040,canshu_041,canshu_042,canshu_043,canshu_044,canshu_045,canshu_046,canshu_047,canshu_048,canshu_049,canshu_050,canshu_051,canshu_052,canshu_053,canshu_054,canshu_055,canshu_056,canshu_057,canshu_058,canshu_059,canshu_060,canshu_061,canshu_062,canshu_063,canshu_064,canshu_065,canshu_066,canshu_067,canshu_068,canshu_069,canshu_070,canshu_071,canshu_072,canshu_073,canshu_074,canshu_075,canshu_076,canshu_077,canshu_078,canshu_079,canshu_080,canshu_081,canshu_082,canshu_083,canshu_084,canshu_085,canshu_086,canshu_087,canshu_088,canshu_089,canshu_090,canshu_091,canshu_092,canshu_093,canshu_094,canshu_095,canshu_096,canshu_097,canshu_098,canshu_099,canshu_100,tikuan_sx,tikuan_di,jiesuan_flag,dispose_time ");
            strSql.Append(" FROM [tbl_canshu] ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_gonggao"] != null)
                {
                    this.canshu_gonggao = ds.Tables[0].Rows[0]["canshu_gonggao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sys_name"] != null)
                {
                    this.sys_name = ds.Tables[0].Rows[0]["sys_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["reg_shoping"].ToString() != "")
                {
                    this.reg_shoping = int.Parse(ds.Tables[0].Rows[0]["reg_shoping"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_001"].ToString() != "")
                {
                    this.canshu_001 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_001"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_002"].ToString() != "")
                {
                    this.canshu_002 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_002"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_003"].ToString() != "")
                {
                    this.canshu_003 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_003"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_004"].ToString() != "")
                {
                    this.canshu_004 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_004"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_005"].ToString() != "")
                {
                    this.canshu_005 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_005"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_006"].ToString() != "")
                {
                    this.canshu_006 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_006"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_007"].ToString() != "")
                {
                    this.canshu_007 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_007"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_008"].ToString() != "")
                {
                    this.canshu_008 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_008"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_009"].ToString() != "")
                {
                    this.canshu_009 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_009"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_010"].ToString() != "")
                {
                    this.canshu_010 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_010"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_011"].ToString() != "")
                {
                    this.canshu_011 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_011"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_012"].ToString() != "")
                {
                    this.canshu_012 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_012"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_013"].ToString() != "")
                {
                    this.canshu_013 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_013"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_014"].ToString() != "")
                {
                    this.canshu_014 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_014"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_015"].ToString() != "")
                {
                    this.canshu_015 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_015"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_016"].ToString() != "")
                {
                    this.canshu_016 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_016"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_017"].ToString() != "")
                {
                    this.canshu_017 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_017"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_018"].ToString() != "")
                {
                    this.canshu_018 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_018"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_019"].ToString() != "")
                {
                    this.canshu_019 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_019"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_020"].ToString() != "")
                {
                    this.canshu_020 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_020"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_021"].ToString() != "")
                {
                    this.canshu_021 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_021"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_022"].ToString() != "")
                {
                    this.canshu_022 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_022"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_023"].ToString() != "")
                {
                    this.canshu_023 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_023"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_024"].ToString() != "")
                {
                    this.canshu_024 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_024"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_025"].ToString() != "")
                {
                    this.canshu_025 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_025"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_026"].ToString() != "")
                {
                    this.canshu_026 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_026"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_027"].ToString() != "")
                {
                    this.canshu_027 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_027"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_028"].ToString() != "")
                {
                    this.canshu_028 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_028"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_029"].ToString() != "")
                {
                    this.canshu_029 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_029"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_030"].ToString() != "")
                {
                    this.canshu_030 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_030"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_031"].ToString() != "")
                {
                    this.canshu_031 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_031"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_032"].ToString() != "")
                {
                    this.canshu_032 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_032"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_033"].ToString() != "")
                {
                    this.canshu_033 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_033"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_034"].ToString() != "")
                {
                    this.canshu_034 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_034"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_035"].ToString() != "")
                {
                    this.canshu_035 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_035"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_036"].ToString() != "")
                {
                    this.canshu_036 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_036"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_037"].ToString() != "")
                {
                    this.canshu_037 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_037"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_038"].ToString() != "")
                {
                    this.canshu_038 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_038"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_039"].ToString() != "")
                {
                    this.canshu_039 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_039"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_040"].ToString() != "")
                {
                    this.canshu_040 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_040"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_041"].ToString() != "")
                {
                    this.canshu_041 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_041"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_042"].ToString() != "")
                {
                    this.canshu_042 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_042"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_043"].ToString() != "")
                {
                    this.canshu_043 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_043"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_044"].ToString() != "")
                {
                    this.canshu_044 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_044"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_045"].ToString() != "")
                {
                    this.canshu_045 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_045"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_046"].ToString() != "")
                {
                    this.canshu_046 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_046"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_047"].ToString() != "")
                {
                    this.canshu_047 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_047"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_048"].ToString() != "")
                {
                    this.canshu_048 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_048"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_049"].ToString() != "")
                {
                    this.canshu_049 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_049"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_050"].ToString() != "")
                {
                    this.canshu_050 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_050"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_051"].ToString() != "")
                {
                    this.canshu_051 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_051"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_052"].ToString() != "")
                {
                    this.canshu_052 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_052"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_053"].ToString() != "")
                {
                    this.canshu_053 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_053"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_054"].ToString() != "")
                {
                    this.canshu_054 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_054"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_055"].ToString() != "")
                {
                    this.canshu_055 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_055"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_056"].ToString() != "")
                {
                    this.canshu_056 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_056"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_057"].ToString() != "")
                {
                    this.canshu_057 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_057"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_058"].ToString() != "")
                {
                    this.canshu_058 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_058"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_059"].ToString() != "")
                {
                    this.canshu_059 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_059"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_060"].ToString() != "")
                {
                    this.canshu_060 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_060"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_061"].ToString() != "")
                {
                    this.canshu_061 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_061"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_062"].ToString() != "")
                {
                    this.canshu_062 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_062"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_063"].ToString() != "")
                {
                    this.canshu_063 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_063"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_064"].ToString() != "")
                {
                    this.canshu_064 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_064"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_065"].ToString() != "")
                {
                    this.canshu_065 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_065"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_066"].ToString() != "")
                {
                    this.canshu_066 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_066"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_067"].ToString() != "")
                {
                    this.canshu_067 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_067"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_068"].ToString() != "")
                {
                    this.canshu_068 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_068"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_069"].ToString() != "")
                {
                    this.canshu_069 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_069"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_070"].ToString() != "")
                {
                    this.canshu_070 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_070"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_071"].ToString() != "")
                {
                    this.canshu_071 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_071"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_072"].ToString() != "")
                {
                    this.canshu_072 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_072"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_073"].ToString() != "")
                {
                    this.canshu_073 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_073"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_074"].ToString() != "")
                {
                    this.canshu_074 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_074"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_075"].ToString() != "")
                {
                    this.canshu_075 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_075"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_076"].ToString() != "")
                {
                    this.canshu_076 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_076"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_077"].ToString() != "")
                {
                    this.canshu_077 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_077"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_078"].ToString() != "")
                {
                    this.canshu_078 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_078"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_079"].ToString() != "")
                {
                    this.canshu_079 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_079"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_080"].ToString() != "")
                {
                    this.canshu_080 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_080"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_081"].ToString() != "")
                {
                    this.canshu_081 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_081"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_082"].ToString() != "")
                {
                    this.canshu_082 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_082"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_083"].ToString() != "")
                {
                    this.canshu_083 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_083"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_084"].ToString() != "")
                {
                    this.canshu_084 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_084"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_085"].ToString() != "")
                {
                    this.canshu_085 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_085"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_086"].ToString() != "")
                {
                    this.canshu_086 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_086"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_087"].ToString() != "")
                {
                    this.canshu_087 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_087"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_088"].ToString() != "")
                {
                    this.canshu_088 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_088"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_089"].ToString() != "")
                {
                    this.canshu_089 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_089"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_090"].ToString() != "")
                {
                    this.canshu_090 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_090"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_091"].ToString() != "")
                {
                    this.canshu_091 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_091"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_092"].ToString() != "")
                {
                    this.canshu_092 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_092"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_093"].ToString() != "")
                {
                    this.canshu_093 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_093"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_094"].ToString() != "")
                {
                    this.canshu_094 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_094"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_095"].ToString() != "")
                {
                    this.canshu_095 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_095"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_096"].ToString() != "")
                {
                    this.canshu_096 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_096"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_097"].ToString() != "")
                {
                    this.canshu_097 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_097"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_098"].ToString() != "")
                {
                    this.canshu_098 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_098"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_099"].ToString() != "")
                {
                    this.canshu_099 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_099"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_100"].ToString() != "")
                {
                    this.canshu_100 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_100"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tikuan_sx"].ToString() != "")
                {
                    this.tikuan_sx = decimal.Parse(ds.Tables[0].Rows[0]["tikuan_sx"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tikuan_di"].ToString() != "")
                {
                    this.tikuan_di = decimal.Parse(ds.Tables[0].Rows[0]["tikuan_di"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiesuan_flag"].ToString() != "")
                {
                    this.jiesuan_flag = int.Parse(ds.Tables[0].Rows[0]["jiesuan_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dispose_time"].ToString() != "")
                {
                    this.dispose_time = DateTime.Parse(ds.Tables[0].Rows[0]["dispose_time"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbl_canshu]");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [tbl_canshu] (");
            strSql.Append("canshu_gonggao,reg_shoping,canshu_001,canshu_002,canshu_003,canshu_004,canshu_005,canshu_006,canshu_007,canshu_008,canshu_009,canshu_010,canshu_011,canshu_012,canshu_013,canshu_014,canshu_015,canshu_016,canshu_017,canshu_018,canshu_019,canshu_020,canshu_021,canshu_022,canshu_023,canshu_024,canshu_025,canshu_026,canshu_027,canshu_028,canshu_029,canshu_030,canshu_031,canshu_032,canshu_033,canshu_034,canshu_035,canshu_036,canshu_037,canshu_038,canshu_039,canshu_040,canshu_041,canshu_042,canshu_043,canshu_044,canshu_045,canshu_046,canshu_047,canshu_048,canshu_049,canshu_050,canshu_051,canshu_052,canshu_053,canshu_054,canshu_055,canshu_056,canshu_057,canshu_058,canshu_059,canshu_060,canshu_061,canshu_062,canshu_063,canshu_064,canshu_065,canshu_066,canshu_067,canshu_068,canshu_069,canshu_070,canshu_071,canshu_072,canshu_073,canshu_074,canshu_075,canshu_076,canshu_077,canshu_078,canshu_079,canshu_080,canshu_081,canshu_082,canshu_083,canshu_084,canshu_085,canshu_086,canshu_087,canshu_088,canshu_089,canshu_090,canshu_091,canshu_092,canshu_093,canshu_094,canshu_095,canshu_096,canshu_097,canshu_098,canshu_099,canshu_100,tikuan_sx,tikuan_di,jiesuan_flag,dispose_time)");
            strSql.Append(" values (");
            strSql.Append("@canshu_gonggao,@reg_shoping,@canshu_001,@canshu_002,@canshu_003,@canshu_004,@canshu_005,@canshu_006,@canshu_007,@canshu_008,@canshu_009,@canshu_010,@canshu_011,@canshu_012,@canshu_013,@canshu_014,@canshu_015,@canshu_016,@canshu_017,@canshu_018,@canshu_019,@canshu_020,@canshu_021,@canshu_022,@canshu_023,@canshu_024,@canshu_025,@canshu_026,@canshu_027,@canshu_028,@canshu_029,@canshu_030,@canshu_031,@canshu_032,@canshu_033,@canshu_034,@canshu_035,@canshu_036,@canshu_037,@canshu_038,@canshu_039,@canshu_040,@canshu_041,@canshu_042,@canshu_043,@canshu_044,@canshu_045,@canshu_046,@canshu_047,@canshu_048,@canshu_049,@canshu_050,@canshu_051,@canshu_052,@canshu_053,@canshu_054,@canshu_055,@canshu_056,@canshu_057,@canshu_058,@canshu_059,@canshu_060,@canshu_061,@canshu_062,@canshu_063,@canshu_064,@canshu_065,@canshu_066,@canshu_067,@canshu_068,@canshu_069,@canshu_070,@canshu_071,@canshu_072,@canshu_073,@canshu_074,@canshu_075,@canshu_076,@canshu_077,@canshu_078,@canshu_079,@canshu_080,@canshu_081,@canshu_082,@canshu_083,@canshu_084,@canshu_085,@canshu_086,@canshu_087,@canshu_088,@canshu_089,@canshu_090,@canshu_091,@canshu_092,@canshu_093,@canshu_094,@canshu_095,@canshu_096,@canshu_097,@canshu_098,@canshu_099,@canshu_100,@tikuan_sx,@tikuan_di,@jiesuan_flag,@dispose_time)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@canshu_gonggao", SqlDbType.VarChar,8000),
					new SqlParameter("@reg_shoping", SqlDbType.Int,4),
					new SqlParameter("@canshu_001", SqlDbType.Money,8),
					new SqlParameter("@canshu_002", SqlDbType.Money,8),
					new SqlParameter("@canshu_003", SqlDbType.Money,8),
					new SqlParameter("@canshu_004", SqlDbType.Money,8),
					new SqlParameter("@canshu_005", SqlDbType.Money,8),
					new SqlParameter("@canshu_006", SqlDbType.Money,8),
					new SqlParameter("@canshu_007", SqlDbType.Money,8),
					new SqlParameter("@canshu_008", SqlDbType.Money,8),
					new SqlParameter("@canshu_009", SqlDbType.Money,8),
					new SqlParameter("@canshu_010", SqlDbType.Money,8),
					new SqlParameter("@canshu_011", SqlDbType.Money,8),
					new SqlParameter("@canshu_012", SqlDbType.Money,8),
					new SqlParameter("@canshu_013", SqlDbType.Money,8),
					new SqlParameter("@canshu_014", SqlDbType.Money,8),
					new SqlParameter("@canshu_015", SqlDbType.Money,8),
					new SqlParameter("@canshu_016", SqlDbType.Money,8),
					new SqlParameter("@canshu_017", SqlDbType.Money,8),
					new SqlParameter("@canshu_018", SqlDbType.Money,8),
					new SqlParameter("@canshu_019", SqlDbType.Money,8),
					new SqlParameter("@canshu_020", SqlDbType.Money,8),
					new SqlParameter("@canshu_021", SqlDbType.Money,8),
					new SqlParameter("@canshu_022", SqlDbType.Money,8),
					new SqlParameter("@canshu_023", SqlDbType.Money,8),
					new SqlParameter("@canshu_024", SqlDbType.Money,8),
					new SqlParameter("@canshu_025", SqlDbType.Money,8),
					new SqlParameter("@canshu_026", SqlDbType.Money,8),
					new SqlParameter("@canshu_027", SqlDbType.Money,8),
					new SqlParameter("@canshu_028", SqlDbType.Money,8),
					new SqlParameter("@canshu_029", SqlDbType.Money,8),
					new SqlParameter("@canshu_030", SqlDbType.Money,8),
					new SqlParameter("@canshu_031", SqlDbType.Money,8),
					new SqlParameter("@canshu_032", SqlDbType.Money,8),
					new SqlParameter("@canshu_033", SqlDbType.Money,8),
					new SqlParameter("@canshu_034", SqlDbType.Money,8),
					new SqlParameter("@canshu_035", SqlDbType.Money,8),
					new SqlParameter("@canshu_036", SqlDbType.Money,8),
					new SqlParameter("@canshu_037", SqlDbType.Money,8),
					new SqlParameter("@canshu_038", SqlDbType.Money,8),
					new SqlParameter("@canshu_039", SqlDbType.Money,8),
					new SqlParameter("@canshu_040", SqlDbType.Money,8),
					new SqlParameter("@canshu_041", SqlDbType.Money,8),
					new SqlParameter("@canshu_042", SqlDbType.Money,8),
					new SqlParameter("@canshu_043", SqlDbType.Money,8),
					new SqlParameter("@canshu_044", SqlDbType.Money,8),
					new SqlParameter("@canshu_045", SqlDbType.Money,8),
					new SqlParameter("@canshu_046", SqlDbType.Money,8),
					new SqlParameter("@canshu_047", SqlDbType.Money,8),
					new SqlParameter("@canshu_048", SqlDbType.Money,8),
					new SqlParameter("@canshu_049", SqlDbType.Money,8),
					new SqlParameter("@canshu_050", SqlDbType.Money,8),
					new SqlParameter("@canshu_051", SqlDbType.Money,8),
					new SqlParameter("@canshu_052", SqlDbType.Money,8),
					new SqlParameter("@canshu_053", SqlDbType.Money,8),
					new SqlParameter("@canshu_054", SqlDbType.Money,8),
					new SqlParameter("@canshu_055", SqlDbType.Money,8),
					new SqlParameter("@canshu_056", SqlDbType.Money,8),
					new SqlParameter("@canshu_057", SqlDbType.Money,8),
					new SqlParameter("@canshu_058", SqlDbType.Money,8),
					new SqlParameter("@canshu_059", SqlDbType.Money,8),
					new SqlParameter("@canshu_060", SqlDbType.Money,8),
					new SqlParameter("@canshu_061", SqlDbType.Money,8),
					new SqlParameter("@canshu_062", SqlDbType.Money,8),
					new SqlParameter("@canshu_063", SqlDbType.Money,8),
					new SqlParameter("@canshu_064", SqlDbType.Money,8),
					new SqlParameter("@canshu_065", SqlDbType.Money,8),
					new SqlParameter("@canshu_066", SqlDbType.Money,8),
					new SqlParameter("@canshu_067", SqlDbType.Money,8),
					new SqlParameter("@canshu_068", SqlDbType.Money,8),
					new SqlParameter("@canshu_069", SqlDbType.Money,8),
					new SqlParameter("@canshu_070", SqlDbType.Money,8),
					new SqlParameter("@canshu_071", SqlDbType.Money,8),
					new SqlParameter("@canshu_072", SqlDbType.Money,8),
					new SqlParameter("@canshu_073", SqlDbType.Money,8),
					new SqlParameter("@canshu_074", SqlDbType.Money,8),
					new SqlParameter("@canshu_075", SqlDbType.Money,8),
					new SqlParameter("@canshu_076", SqlDbType.Money,8),
					new SqlParameter("@canshu_077", SqlDbType.Money,8),
					new SqlParameter("@canshu_078", SqlDbType.Money,8),
					new SqlParameter("@canshu_079", SqlDbType.Money,8),
					new SqlParameter("@canshu_080", SqlDbType.Money,8),
					new SqlParameter("@canshu_081", SqlDbType.Money,8),
					new SqlParameter("@canshu_082", SqlDbType.Money,8),
					new SqlParameter("@canshu_083", SqlDbType.Money,8),
					new SqlParameter("@canshu_084", SqlDbType.Money,8),
					new SqlParameter("@canshu_085", SqlDbType.Money,8),
					new SqlParameter("@canshu_086", SqlDbType.Money,8),
					new SqlParameter("@canshu_087", SqlDbType.Money,8),
					new SqlParameter("@canshu_088", SqlDbType.Money,8),
					new SqlParameter("@canshu_089", SqlDbType.Money,8),
					new SqlParameter("@canshu_090", SqlDbType.Money,8),
					new SqlParameter("@canshu_091", SqlDbType.Money,8),
					new SqlParameter("@canshu_092", SqlDbType.Money,8),
					new SqlParameter("@canshu_093", SqlDbType.Money,8),
					new SqlParameter("@canshu_094", SqlDbType.Money,8),
					new SqlParameter("@canshu_095", SqlDbType.Money,8),
					new SqlParameter("@canshu_096", SqlDbType.Money,8),
					new SqlParameter("@canshu_097", SqlDbType.Money,8),
					new SqlParameter("@canshu_098", SqlDbType.Money,8),
					new SqlParameter("@canshu_099", SqlDbType.Money,8),
					new SqlParameter("@canshu_100", SqlDbType.Money,8),
					new SqlParameter("@tikuan_sx", SqlDbType.Money,8),
					new SqlParameter("@tikuan_di", SqlDbType.Money,8),
					new SqlParameter("@jiesuan_flag", SqlDbType.Int,4),
                    new SqlParameter("@dispose_time", SqlDbType.DateTime)};
            parameters[0].Value = canshu_gonggao;
            parameters[1].Value = reg_shoping;
            parameters[2].Value = canshu_001;
            parameters[3].Value = canshu_002;
            parameters[4].Value = canshu_003;
            parameters[5].Value = canshu_004;
            parameters[6].Value = canshu_005;
            parameters[7].Value = canshu_006;
            parameters[8].Value = canshu_007;
            parameters[9].Value = canshu_008;
            parameters[10].Value = canshu_009;
            parameters[11].Value = canshu_010;
            parameters[12].Value = canshu_011;
            parameters[13].Value = canshu_012;
            parameters[14].Value = canshu_013;
            parameters[15].Value = canshu_014;
            parameters[16].Value = canshu_015;
            parameters[17].Value = canshu_016;
            parameters[18].Value = canshu_017;
            parameters[19].Value = canshu_018;
            parameters[20].Value = canshu_019;
            parameters[21].Value = canshu_020;
            parameters[22].Value = canshu_021;
            parameters[23].Value = canshu_022;
            parameters[24].Value = canshu_023;
            parameters[25].Value = canshu_024;
            parameters[26].Value = canshu_025;
            parameters[27].Value = canshu_026;
            parameters[28].Value = canshu_027;
            parameters[29].Value = canshu_028;
            parameters[30].Value = canshu_029;
            parameters[31].Value = canshu_030;
            parameters[32].Value = canshu_031;
            parameters[33].Value = canshu_032;
            parameters[34].Value = canshu_033;
            parameters[35].Value = canshu_034;
            parameters[36].Value = canshu_035;
            parameters[37].Value = canshu_036;
            parameters[38].Value = canshu_037;
            parameters[39].Value = canshu_038;
            parameters[40].Value = canshu_039;
            parameters[41].Value = canshu_040;
            parameters[42].Value = canshu_041;
            parameters[43].Value = canshu_042;
            parameters[44].Value = canshu_043;
            parameters[45].Value = canshu_044;
            parameters[46].Value = canshu_045;
            parameters[47].Value = canshu_046;
            parameters[48].Value = canshu_047;
            parameters[49].Value = canshu_048;
            parameters[50].Value = canshu_049;
            parameters[51].Value = canshu_050;
            parameters[52].Value = canshu_051;
            parameters[53].Value = canshu_052;
            parameters[54].Value = canshu_053;
            parameters[55].Value = canshu_054;
            parameters[56].Value = canshu_055;
            parameters[57].Value = canshu_056;
            parameters[58].Value = canshu_057;
            parameters[59].Value = canshu_058;
            parameters[60].Value = canshu_059;
            parameters[61].Value = canshu_060;
            parameters[62].Value = canshu_061;
            parameters[63].Value = canshu_062;
            parameters[64].Value = canshu_063;
            parameters[65].Value = canshu_064;
            parameters[66].Value = canshu_065;
            parameters[67].Value = canshu_066;
            parameters[68].Value = canshu_067;
            parameters[69].Value = canshu_068;
            parameters[70].Value = canshu_069;
            parameters[71].Value = canshu_070;
            parameters[72].Value = canshu_071;
            parameters[73].Value = canshu_072;
            parameters[74].Value = canshu_073;
            parameters[75].Value = canshu_074;
            parameters[76].Value = canshu_075;
            parameters[77].Value = canshu_076;
            parameters[78].Value = canshu_077;
            parameters[79].Value = canshu_078;
            parameters[80].Value = canshu_079;
            parameters[81].Value = canshu_080;
            parameters[82].Value = canshu_081;
            parameters[83].Value = canshu_082;
            parameters[84].Value = canshu_083;
            parameters[85].Value = canshu_084;
            parameters[86].Value = canshu_085;
            parameters[87].Value = canshu_086;
            parameters[88].Value = canshu_087;
            parameters[89].Value = canshu_088;
            parameters[90].Value = canshu_089;
            parameters[91].Value = canshu_090;
            parameters[92].Value = canshu_091;
            parameters[93].Value = canshu_092;
            parameters[94].Value = canshu_093;
            parameters[95].Value = canshu_094;
            parameters[96].Value = canshu_095;
            parameters[97].Value = canshu_096;
            parameters[98].Value = canshu_097;
            parameters[99].Value = canshu_098;
            parameters[100].Value = canshu_099;
            parameters[101].Value = canshu_100;
            parameters[102].Value = tikuan_sx;
            parameters[103].Value = tikuan_di;
            parameters[104].Value = jiesuan_flag;
            parameters[105].Value = dispose_time;
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tbl_canshu] set ");
            strSql.Append("canshu_gonggao=@canshu_gonggao,");
            strSql.Append("sys_name=@sys_name,");
            strSql.Append("reg_shoping=@reg_shoping,");
            strSql.Append("canshu_001=@canshu_001,");
            strSql.Append("canshu_002=@canshu_002,");
            strSql.Append("canshu_003=@canshu_003,");
            strSql.Append("canshu_004=@canshu_004,");
            strSql.Append("canshu_005=@canshu_005,");
            strSql.Append("canshu_006=@canshu_006,");
            strSql.Append("canshu_007=@canshu_007,");
            strSql.Append("canshu_008=@canshu_008,");
            strSql.Append("canshu_009=@canshu_009,");
            strSql.Append("canshu_010=@canshu_010,");
            strSql.Append("canshu_011=@canshu_011,");
            strSql.Append("canshu_012=@canshu_012,");
            strSql.Append("canshu_013=@canshu_013,");
            strSql.Append("canshu_014=@canshu_014,");
            strSql.Append("canshu_015=@canshu_015,");
            strSql.Append("canshu_016=@canshu_016,");
            strSql.Append("canshu_017=@canshu_017,");
            strSql.Append("canshu_018=@canshu_018,");
            strSql.Append("canshu_019=@canshu_019,");
            strSql.Append("canshu_020=@canshu_020,");
            strSql.Append("canshu_021=@canshu_021,");
            strSql.Append("canshu_022=@canshu_022,");
            strSql.Append("canshu_023=@canshu_023,");
            strSql.Append("canshu_024=@canshu_024,");
            strSql.Append("canshu_025=@canshu_025,");
            strSql.Append("canshu_026=@canshu_026,");
            strSql.Append("canshu_027=@canshu_027,");
            strSql.Append("canshu_028=@canshu_028,");
            strSql.Append("canshu_029=@canshu_029,");
            strSql.Append("canshu_030=@canshu_030,");
            strSql.Append("canshu_031=@canshu_031,");
            strSql.Append("canshu_032=@canshu_032,");
            strSql.Append("canshu_033=@canshu_033,");
            strSql.Append("canshu_034=@canshu_034,");
            strSql.Append("canshu_035=@canshu_035,");
            strSql.Append("canshu_036=@canshu_036,");
            strSql.Append("canshu_037=@canshu_037,");
            strSql.Append("canshu_038=@canshu_038,");
            strSql.Append("canshu_039=@canshu_039,");
            strSql.Append("canshu_040=@canshu_040,");
            strSql.Append("canshu_041=@canshu_041,");
            strSql.Append("canshu_042=@canshu_042,");
            strSql.Append("canshu_043=@canshu_043,");
            strSql.Append("canshu_044=@canshu_044,");
            strSql.Append("canshu_045=@canshu_045,");
            strSql.Append("canshu_046=@canshu_046,");
            strSql.Append("canshu_047=@canshu_047,");
            strSql.Append("canshu_048=@canshu_048,");
            strSql.Append("canshu_049=@canshu_049,");
            strSql.Append("canshu_050=@canshu_050,");
            strSql.Append("canshu_051=@canshu_051,");
            strSql.Append("canshu_052=@canshu_052,");
            strSql.Append("canshu_053=@canshu_053,");
            strSql.Append("canshu_054=@canshu_054,");
            strSql.Append("canshu_055=@canshu_055,");
            strSql.Append("canshu_056=@canshu_056,");
            strSql.Append("canshu_057=@canshu_057,");
            strSql.Append("canshu_058=@canshu_058,");
            strSql.Append("canshu_059=@canshu_059,");
            strSql.Append("canshu_060=@canshu_060,");
            strSql.Append("canshu_061=@canshu_061,");
            strSql.Append("canshu_062=@canshu_062,");
            strSql.Append("canshu_063=@canshu_063,");
            strSql.Append("canshu_064=@canshu_064,");
            strSql.Append("canshu_065=@canshu_065,");
            strSql.Append("canshu_066=@canshu_066,");
            strSql.Append("canshu_067=@canshu_067,");
            strSql.Append("canshu_068=@canshu_068,");
            strSql.Append("canshu_069=@canshu_069,");
            strSql.Append("canshu_070=@canshu_070,");
            strSql.Append("canshu_071=@canshu_071,");
            strSql.Append("canshu_072=@canshu_072,");
            strSql.Append("canshu_073=@canshu_073,");
            strSql.Append("canshu_074=@canshu_074,");
            strSql.Append("canshu_075=@canshu_075,");
            strSql.Append("canshu_076=@canshu_076,");
            strSql.Append("canshu_077=@canshu_077,");
            strSql.Append("canshu_078=@canshu_078,");
            strSql.Append("canshu_079=@canshu_079,");
            strSql.Append("canshu_080=@canshu_080,");
            strSql.Append("canshu_081=@canshu_081,");
            strSql.Append("canshu_082=@canshu_082,");
            strSql.Append("canshu_083=@canshu_083,");
            strSql.Append("canshu_084=@canshu_084,");
            strSql.Append("canshu_085=@canshu_085,");
            strSql.Append("canshu_086=@canshu_086,");
            strSql.Append("canshu_087=@canshu_087,");
            strSql.Append("canshu_088=@canshu_088,");
            strSql.Append("canshu_089=@canshu_089,");
            strSql.Append("canshu_090=@canshu_090,");
            strSql.Append("canshu_091=@canshu_091,");
            strSql.Append("canshu_092=@canshu_092,");
            strSql.Append("canshu_093=@canshu_093,");
            strSql.Append("canshu_094=@canshu_094,");
            strSql.Append("canshu_095=@canshu_095,");
            strSql.Append("canshu_096=@canshu_096,");
            strSql.Append("canshu_097=@canshu_097,");
            strSql.Append("canshu_098=@canshu_098,");
            strSql.Append("canshu_099=@canshu_099,");
            strSql.Append("canshu_100=@canshu_100,");
            strSql.Append("tikuan_sx=@tikuan_sx,");
            strSql.Append("tikuan_di=@tikuan_di,");
            strSql.Append("jiesuan_flag=@jiesuan_flag,");
            strSql.Append("dispose_time=@dispose_time");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@canshu_gonggao", SqlDbType.VarChar,8000),
					new SqlParameter("@sys_name", SqlDbType.VarChar,8000),
					new SqlParameter("@reg_shoping", SqlDbType.Int,4),
					new SqlParameter("@canshu_001", SqlDbType.Money,8),
					new SqlParameter("@canshu_002", SqlDbType.Money,8),
					new SqlParameter("@canshu_003", SqlDbType.Money,8),
					new SqlParameter("@canshu_004", SqlDbType.Money,8),
					new SqlParameter("@canshu_005", SqlDbType.Money,8),
					new SqlParameter("@canshu_006", SqlDbType.Money,8),
					new SqlParameter("@canshu_007", SqlDbType.Money,8),
					new SqlParameter("@canshu_008", SqlDbType.Money,8),
					new SqlParameter("@canshu_009", SqlDbType.Money,8),
					new SqlParameter("@canshu_010", SqlDbType.Money,8),
					new SqlParameter("@canshu_011", SqlDbType.Money,8),
					new SqlParameter("@canshu_012", SqlDbType.Money,8),
					new SqlParameter("@canshu_013", SqlDbType.Money,8),
					new SqlParameter("@canshu_014", SqlDbType.Money,8),
					new SqlParameter("@canshu_015", SqlDbType.Money,8),
					new SqlParameter("@canshu_016", SqlDbType.Money,8),
					new SqlParameter("@canshu_017", SqlDbType.Money,8),
					new SqlParameter("@canshu_018", SqlDbType.Money,8),
					new SqlParameter("@canshu_019", SqlDbType.Money,8),
					new SqlParameter("@canshu_020", SqlDbType.Money,8),
					new SqlParameter("@canshu_021", SqlDbType.Money,8),
					new SqlParameter("@canshu_022", SqlDbType.Money,8),
					new SqlParameter("@canshu_023", SqlDbType.Money,8),
					new SqlParameter("@canshu_024", SqlDbType.Money,8),
					new SqlParameter("@canshu_025", SqlDbType.Money,8),
					new SqlParameter("@canshu_026", SqlDbType.Money,8),
					new SqlParameter("@canshu_027", SqlDbType.Money,8),
					new SqlParameter("@canshu_028", SqlDbType.Money,8),
					new SqlParameter("@canshu_029", SqlDbType.Money,8),
					new SqlParameter("@canshu_030", SqlDbType.Money,8),
					new SqlParameter("@canshu_031", SqlDbType.Money,8),
					new SqlParameter("@canshu_032", SqlDbType.Money,8),
					new SqlParameter("@canshu_033", SqlDbType.Money,8),
					new SqlParameter("@canshu_034", SqlDbType.Money,8),
					new SqlParameter("@canshu_035", SqlDbType.Money,8),
					new SqlParameter("@canshu_036", SqlDbType.Money,8),
					new SqlParameter("@canshu_037", SqlDbType.Money,8),
					new SqlParameter("@canshu_038", SqlDbType.Money,8),
					new SqlParameter("@canshu_039", SqlDbType.Money,8),
					new SqlParameter("@canshu_040", SqlDbType.Money,8),
					new SqlParameter("@canshu_041", SqlDbType.Money,8),
					new SqlParameter("@canshu_042", SqlDbType.Money,8),
					new SqlParameter("@canshu_043", SqlDbType.Money,8),
					new SqlParameter("@canshu_044", SqlDbType.Money,8),
					new SqlParameter("@canshu_045", SqlDbType.Money,8),
					new SqlParameter("@canshu_046", SqlDbType.Money,8),
					new SqlParameter("@canshu_047", SqlDbType.Money,8),
					new SqlParameter("@canshu_048", SqlDbType.Money,8),
					new SqlParameter("@canshu_049", SqlDbType.Money,8),
					new SqlParameter("@canshu_050", SqlDbType.Money,8),
					new SqlParameter("@canshu_051", SqlDbType.Money,8),
					new SqlParameter("@canshu_052", SqlDbType.Money,8),
					new SqlParameter("@canshu_053", SqlDbType.Money,8),
					new SqlParameter("@canshu_054", SqlDbType.Money,8),
					new SqlParameter("@canshu_055", SqlDbType.Money,8),
					new SqlParameter("@canshu_056", SqlDbType.Money,8),
					new SqlParameter("@canshu_057", SqlDbType.Money,8),
					new SqlParameter("@canshu_058", SqlDbType.Money,8),
					new SqlParameter("@canshu_059", SqlDbType.Money,8),
					new SqlParameter("@canshu_060", SqlDbType.Money,8),
					new SqlParameter("@canshu_061", SqlDbType.Money,8),
					new SqlParameter("@canshu_062", SqlDbType.Money,8),
					new SqlParameter("@canshu_063", SqlDbType.Money,8),
					new SqlParameter("@canshu_064", SqlDbType.Money,8),
					new SqlParameter("@canshu_065", SqlDbType.Money,8),
					new SqlParameter("@canshu_066", SqlDbType.Money,8),
					new SqlParameter("@canshu_067", SqlDbType.Money,8),
					new SqlParameter("@canshu_068", SqlDbType.Money,8),
					new SqlParameter("@canshu_069", SqlDbType.Money,8),
					new SqlParameter("@canshu_070", SqlDbType.Money,8),
					new SqlParameter("@canshu_071", SqlDbType.Money,8),
					new SqlParameter("@canshu_072", SqlDbType.Money,8),
					new SqlParameter("@canshu_073", SqlDbType.Money,8),
					new SqlParameter("@canshu_074", SqlDbType.Money,8),
					new SqlParameter("@canshu_075", SqlDbType.Money,8),
					new SqlParameter("@canshu_076", SqlDbType.Money,8),
					new SqlParameter("@canshu_077", SqlDbType.Money,8),
					new SqlParameter("@canshu_078", SqlDbType.Money,8),
					new SqlParameter("@canshu_079", SqlDbType.Money,8),
					new SqlParameter("@canshu_080", SqlDbType.Money,8),
					new SqlParameter("@canshu_081", SqlDbType.Money,8),
					new SqlParameter("@canshu_082", SqlDbType.Money,8),
					new SqlParameter("@canshu_083", SqlDbType.Money,8),
					new SqlParameter("@canshu_084", SqlDbType.Money,8),
					new SqlParameter("@canshu_085", SqlDbType.Money,8),
					new SqlParameter("@canshu_086", SqlDbType.Money,8),
					new SqlParameter("@canshu_087", SqlDbType.Money,8),
					new SqlParameter("@canshu_088", SqlDbType.Money,8),
					new SqlParameter("@canshu_089", SqlDbType.Money,8),
					new SqlParameter("@canshu_090", SqlDbType.Money,8),
					new SqlParameter("@canshu_091", SqlDbType.Money,8),
					new SqlParameter("@canshu_092", SqlDbType.Money,8),
					new SqlParameter("@canshu_093", SqlDbType.Money,8),
					new SqlParameter("@canshu_094", SqlDbType.Money,8),
					new SqlParameter("@canshu_095", SqlDbType.Money,8),
					new SqlParameter("@canshu_096", SqlDbType.Money,8),
					new SqlParameter("@canshu_097", SqlDbType.Money,8),
					new SqlParameter("@canshu_098", SqlDbType.Money,8),
					new SqlParameter("@canshu_099", SqlDbType.Money,8),
					new SqlParameter("@canshu_100", SqlDbType.Money,8),
					new SqlParameter("@tikuan_sx", SqlDbType.Money,8),
					new SqlParameter("@tikuan_di", SqlDbType.Money,8),
					new SqlParameter("@jiesuan_flag", SqlDbType.Int,4),
                    new SqlParameter("@dispose_time", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = canshu_gonggao;
            parameters[1].Value = sys_name;
            parameters[2].Value = reg_shoping;
            parameters[3].Value = canshu_001;
            parameters[4].Value = canshu_002;
            parameters[5].Value = canshu_003;
            parameters[6].Value = canshu_004;
            parameters[7].Value = canshu_005;
            parameters[8].Value = canshu_006;
            parameters[9].Value = canshu_007;
            parameters[10].Value = canshu_008;
            parameters[11].Value = canshu_009;
            parameters[12].Value = canshu_010;
            parameters[13].Value = canshu_011;
            parameters[14].Value = canshu_012;
            parameters[15].Value = canshu_013;
            parameters[16].Value = canshu_014;
            parameters[17].Value = canshu_015;
            parameters[18].Value = canshu_016;
            parameters[19].Value = canshu_017;
            parameters[20].Value = canshu_018;
            parameters[21].Value = canshu_019;
            parameters[22].Value = canshu_020;
            parameters[23].Value = canshu_021;
            parameters[24].Value = canshu_022;
            parameters[25].Value = canshu_023;
            parameters[26].Value = canshu_024;
            parameters[27].Value = canshu_025;
            parameters[28].Value = canshu_026;
            parameters[29].Value = canshu_027;
            parameters[30].Value = canshu_028;
            parameters[31].Value = canshu_029;
            parameters[32].Value = canshu_030;
            parameters[33].Value = canshu_031;
            parameters[34].Value = canshu_032;
            parameters[35].Value = canshu_033;
            parameters[36].Value = canshu_034;
            parameters[37].Value = canshu_035;
            parameters[38].Value = canshu_036;
            parameters[39].Value = canshu_037;
            parameters[40].Value = canshu_038;
            parameters[41].Value = canshu_039;
            parameters[42].Value = canshu_040;
            parameters[43].Value = canshu_041;
            parameters[44].Value = canshu_042;
            parameters[45].Value = canshu_043;
            parameters[46].Value = canshu_044;
            parameters[47].Value = canshu_045;
            parameters[48].Value = canshu_046;
            parameters[49].Value = canshu_047;
            parameters[50].Value = canshu_048;
            parameters[51].Value = canshu_049;
            parameters[52].Value = canshu_050;
            parameters[53].Value = canshu_051;
            parameters[54].Value = canshu_052;
            parameters[55].Value = canshu_053;
            parameters[56].Value = canshu_054;
            parameters[57].Value = canshu_055;
            parameters[58].Value = canshu_056;
            parameters[59].Value = canshu_057;
            parameters[60].Value = canshu_058;
            parameters[61].Value = canshu_059;
            parameters[62].Value = canshu_060;
            parameters[63].Value = canshu_061;
            parameters[64].Value = canshu_062;
            parameters[65].Value = canshu_063;
            parameters[66].Value = canshu_064;
            parameters[67].Value = canshu_065;
            parameters[68].Value = canshu_066;
            parameters[69].Value = canshu_067;
            parameters[70].Value = canshu_068;
            parameters[71].Value = canshu_069;
            parameters[72].Value = canshu_070;
            parameters[73].Value = canshu_071;
            parameters[74].Value = canshu_072;
            parameters[75].Value = canshu_073;
            parameters[76].Value = canshu_074;
            parameters[77].Value = canshu_075;
            parameters[78].Value = canshu_076;
            parameters[79].Value = canshu_077;
            parameters[80].Value = canshu_078;
            parameters[81].Value = canshu_079;
            parameters[82].Value = canshu_080;
            parameters[83].Value = canshu_081;
            parameters[84].Value = canshu_082;
            parameters[85].Value = canshu_083;
            parameters[86].Value = canshu_084;
            parameters[87].Value = canshu_085;
            parameters[88].Value = canshu_086;
            parameters[89].Value = canshu_087;
            parameters[90].Value = canshu_088;
            parameters[91].Value = canshu_089;
            parameters[92].Value = canshu_090;
            parameters[93].Value = canshu_091;
            parameters[94].Value = canshu_092;
            parameters[95].Value = canshu_093;
            parameters[96].Value = canshu_094;
            parameters[97].Value = canshu_095;
            parameters[98].Value = canshu_096;
            parameters[99].Value = canshu_097;
            parameters[100].Value = canshu_098;
            parameters[101].Value = canshu_099;
            parameters[102].Value = canshu_100;
            parameters[103].Value = tikuan_sx;
            parameters[104].Value = tikuan_di;
            parameters[105].Value = jiesuan_flag;
            parameters[106].Value = dispose_time;
            parameters[107].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tbl_canshu] ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,canshu_gonggao,sys_name,reg_shoping,canshu_001,canshu_002,canshu_003,canshu_004,canshu_005,canshu_006,canshu_007,canshu_008,canshu_009,canshu_010,canshu_011,canshu_012,canshu_013,canshu_014,canshu_015,canshu_016,canshu_017,canshu_018,canshu_019,canshu_020,canshu_021,canshu_022,canshu_023,canshu_024,canshu_025,canshu_026,canshu_027,canshu_028,canshu_029,canshu_030,canshu_031,canshu_032,canshu_033,canshu_034,canshu_035,canshu_036,canshu_037,canshu_038,canshu_039,canshu_040,canshu_041,canshu_042,canshu_043,canshu_044,canshu_045,canshu_046,canshu_047,canshu_048,canshu_049,canshu_050,canshu_051,canshu_052,canshu_053,canshu_054,canshu_055,canshu_056,canshu_057,canshu_058,canshu_059,canshu_060,canshu_061,canshu_062,canshu_063,canshu_064,canshu_065,canshu_066,canshu_067,canshu_068,canshu_069,canshu_070,canshu_071,canshu_072,canshu_073,canshu_074,canshu_075,canshu_076,canshu_077,canshu_078,canshu_079,canshu_080,canshu_081,canshu_082,canshu_083,canshu_084,canshu_085,canshu_086,canshu_087,canshu_088,canshu_089,canshu_090,canshu_091,canshu_092,canshu_093,canshu_094,canshu_095,canshu_096,canshu_097,canshu_098,canshu_099,canshu_100,tikuan_sx,tikuan_di,jiesuan_flag,dispose_time ");
            strSql.Append(" FROM [tbl_canshu] ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_gonggao"] != null)
                {
                    this.canshu_gonggao = ds.Tables[0].Rows[0]["canshu_gonggao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sys_name"] != null)
                {
                    this.sys_name = ds.Tables[0].Rows[0]["sys_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["reg_shoping"].ToString() != "")
                {
                    this.reg_shoping = int.Parse(ds.Tables[0].Rows[0]["reg_shoping"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_001"].ToString() != "")
                {
                    this.canshu_001 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_001"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_002"].ToString() != "")
                {
                    this.canshu_002 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_002"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_003"].ToString() != "")
                {
                    this.canshu_003 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_003"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_004"].ToString() != "")
                {
                    this.canshu_004 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_004"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_005"].ToString() != "")
                {
                    this.canshu_005 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_005"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_006"].ToString() != "")
                {
                    this.canshu_006 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_006"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_007"].ToString() != "")
                {
                    this.canshu_007 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_007"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_008"].ToString() != "")
                {
                    this.canshu_008 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_008"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_009"].ToString() != "")
                {
                    this.canshu_009 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_009"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_010"].ToString() != "")
                {
                    this.canshu_010 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_010"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_011"].ToString() != "")
                {
                    this.canshu_011 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_011"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_012"].ToString() != "")
                {
                    this.canshu_012 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_012"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_013"].ToString() != "")
                {
                    this.canshu_013 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_013"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_014"].ToString() != "")
                {
                    this.canshu_014 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_014"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_015"].ToString() != "")
                {
                    this.canshu_015 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_015"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_016"].ToString() != "")
                {
                    this.canshu_016 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_016"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_017"].ToString() != "")
                {
                    this.canshu_017 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_017"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_018"].ToString() != "")
                {
                    this.canshu_018 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_018"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_019"].ToString() != "")
                {
                    this.canshu_019 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_019"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_020"].ToString() != "")
                {
                    this.canshu_020 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_020"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_021"].ToString() != "")
                {
                    this.canshu_021 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_021"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_022"].ToString() != "")
                {
                    this.canshu_022 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_022"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_023"].ToString() != "")
                {
                    this.canshu_023 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_023"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_024"].ToString() != "")
                {
                    this.canshu_024 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_024"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_025"].ToString() != "")
                {
                    this.canshu_025 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_025"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_026"].ToString() != "")
                {
                    this.canshu_026 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_026"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_027"].ToString() != "")
                {
                    this.canshu_027 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_027"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_028"].ToString() != "")
                {
                    this.canshu_028 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_028"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_029"].ToString() != "")
                {
                    this.canshu_029 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_029"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_030"].ToString() != "")
                {
                    this.canshu_030 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_030"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_031"].ToString() != "")
                {
                    this.canshu_031 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_031"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_032"].ToString() != "")
                {
                    this.canshu_032 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_032"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_033"].ToString() != "")
                {
                    this.canshu_033 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_033"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_034"].ToString() != "")
                {
                    this.canshu_034 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_034"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_035"].ToString() != "")
                {
                    this.canshu_035 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_035"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_036"].ToString() != "")
                {
                    this.canshu_036 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_036"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_037"].ToString() != "")
                {
                    this.canshu_037 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_037"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_038"].ToString() != "")
                {
                    this.canshu_038 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_038"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_039"].ToString() != "")
                {
                    this.canshu_039 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_039"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_040"].ToString() != "")
                {
                    this.canshu_040 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_040"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_041"].ToString() != "")
                {
                    this.canshu_041 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_041"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_042"].ToString() != "")
                {
                    this.canshu_042 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_042"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_043"].ToString() != "")
                {
                    this.canshu_043 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_043"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_044"].ToString() != "")
                {
                    this.canshu_044 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_044"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_045"].ToString() != "")
                {
                    this.canshu_045 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_045"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_046"].ToString() != "")
                {
                    this.canshu_046 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_046"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_047"].ToString() != "")
                {
                    this.canshu_047 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_047"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_048"].ToString() != "")
                {
                    this.canshu_048 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_048"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_049"].ToString() != "")
                {
                    this.canshu_049 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_049"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_050"].ToString() != "")
                {
                    this.canshu_050 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_050"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_051"].ToString() != "")
                {
                    this.canshu_051 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_051"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_052"].ToString() != "")
                {
                    this.canshu_052 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_052"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_053"].ToString() != "")
                {
                    this.canshu_053 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_053"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_054"].ToString() != "")
                {
                    this.canshu_054 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_054"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_055"].ToString() != "")
                {
                    this.canshu_055 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_055"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_056"].ToString() != "")
                {
                    this.canshu_056 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_056"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_057"].ToString() != "")
                {
                    this.canshu_057 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_057"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_058"].ToString() != "")
                {
                    this.canshu_058 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_058"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_059"].ToString() != "")
                {
                    this.canshu_059 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_059"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_060"].ToString() != "")
                {
                    this.canshu_060 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_060"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_061"].ToString() != "")
                {
                    this.canshu_061 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_061"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_062"].ToString() != "")
                {
                    this.canshu_062 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_062"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_063"].ToString() != "")
                {
                    this.canshu_063 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_063"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_064"].ToString() != "")
                {
                    this.canshu_064 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_064"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_065"].ToString() != "")
                {
                    this.canshu_065 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_065"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_066"].ToString() != "")
                {
                    this.canshu_066 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_066"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_067"].ToString() != "")
                {
                    this.canshu_067 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_067"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_068"].ToString() != "")
                {
                    this.canshu_068 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_068"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_069"].ToString() != "")
                {
                    this.canshu_069 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_069"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_070"].ToString() != "")
                {
                    this.canshu_070 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_070"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_071"].ToString() != "")
                {
                    this.canshu_071 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_071"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_072"].ToString() != "")
                {
                    this.canshu_072 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_072"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_073"].ToString() != "")
                {
                    this.canshu_073 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_073"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_074"].ToString() != "")
                {
                    this.canshu_074 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_074"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_075"].ToString() != "")
                {
                    this.canshu_075 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_075"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_076"].ToString() != "")
                {
                    this.canshu_076 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_076"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_077"].ToString() != "")
                {
                    this.canshu_077 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_077"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_078"].ToString() != "")
                {
                    this.canshu_078 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_078"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_079"].ToString() != "")
                {
                    this.canshu_079 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_079"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_080"].ToString() != "")
                {
                    this.canshu_080 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_080"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_081"].ToString() != "")
                {
                    this.canshu_081 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_081"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_082"].ToString() != "")
                {
                    this.canshu_082 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_082"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_083"].ToString() != "")
                {
                    this.canshu_083 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_083"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_084"].ToString() != "")
                {
                    this.canshu_084 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_084"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_085"].ToString() != "")
                {
                    this.canshu_085 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_085"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_086"].ToString() != "")
                {
                    this.canshu_086 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_086"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_087"].ToString() != "")
                {
                    this.canshu_087 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_087"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_088"].ToString() != "")
                {
                    this.canshu_088 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_088"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_089"].ToString() != "")
                {
                    this.canshu_089 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_089"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_090"].ToString() != "")
                {
                    this.canshu_090 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_090"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_091"].ToString() != "")
                {
                    this.canshu_091 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_091"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_092"].ToString() != "")
                {
                    this.canshu_092 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_092"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_093"].ToString() != "")
                {
                    this.canshu_093 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_093"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_094"].ToString() != "")
                {
                    this.canshu_094 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_094"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_095"].ToString() != "")
                {
                    this.canshu_095 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_095"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_096"].ToString() != "")
                {
                    this.canshu_096 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_096"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_097"].ToString() != "")
                {
                    this.canshu_097 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_097"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_098"].ToString() != "")
                {
                    this.canshu_098 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_098"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_099"].ToString() != "")
                {
                    this.canshu_099 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_099"].ToString());
                }
                if (ds.Tables[0].Rows[0]["canshu_100"].ToString() != "")
                {
                    this.canshu_100 = decimal.Parse(ds.Tables[0].Rows[0]["canshu_100"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tikuan_sx"].ToString() != "")
                {
                    this.tikuan_sx = decimal.Parse(ds.Tables[0].Rows[0]["tikuan_sx"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tikuan_di"].ToString() != "")
                {
                    this.tikuan_di = decimal.Parse(ds.Tables[0].Rows[0]["tikuan_di"].ToString());
                }
                if (ds.Tables[0].Rows[0]["jiesuan_flag"].ToString() != "")
                {
                    this.jiesuan_flag = int.Parse(ds.Tables[0].Rows[0]["jiesuan_flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dispose_time"].ToString() != "")
                {
                    this.dispose_time = DateTime.Parse(ds.Tables[0].Rows[0]["dispose_time"].ToString());
                }
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [tbl_canshu] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
 

