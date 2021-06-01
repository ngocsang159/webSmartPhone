using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartPhone.Commons
{
    public static class Constant
    {
        //Trang chủ
        //Sản phẩm
        //Chi tiết sản phẩm
        //Tin tức
        //Chi tiết tin tức
        //Chính sách
        public const string cartSession = "CartSession";
        public static long HOME { get; set; } = 4;
        public static long PRODUCT { get; set; } = 6;
        public static long PRODUCTDETAIL { get; set; } = 8;
        public static long NEW { get; set; } = 5;
        public static long NEWDETAIL { get; set; } = 7;
        public static long POLICY { get; set; } = 9;
        public static long COLOR { get; set; } = 2;
        public static long BRAND { get; set; } = 3;
        public static long DISPLAYPAGE { get; set; } = 1;
        public static string ConvertString(string s)
        {
            s = s.ToLower();
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            var str = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            str = str.Replace("/", "-");
            return Regex.Replace(str, @"\s+", "-");
        }
    }
}
