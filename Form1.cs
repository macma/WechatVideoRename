using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"d:\wechatvideo\1");
            foreach (string f in files)
            {
                string fileName = System.IO.Path.GetFileName(f);
                if (fileName.Split('.')[0].Length > 12)
                {
                    string fileTargetName = convertFileName(fileName);
                    string fileTargetPath = f.Replace(fileName, fileTargetName);
                    File.Move(f, fileTargetPath);
                }
            }
        }

        string convertFileName(string fileSourceName)
        {//063845140615df61a6154571
            //065120080515cf48f811771
            //065616160615df61a6161110
            string namehead = fileSourceName.Substring(0, 12);
            string nametail = fileSourceName.Substring(12);
            string year = "20" + namehead.Substring(10, 2);
            string month = namehead.Substring(8, 2);
            string date = namehead.Substring(6, 2);
            string hhmmss = namehead.Substring(0, 6);
            return string.Format("{0}-{1}-{2}-{3}_{4}", year, month, date, hhmmss, nametail);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] files = Directory.GetFiles(@"d:\wechatvideo\1\");
            foreach (string f in files)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    if (f != files[i] && File.Exists(f) && File.Exists(files[i]))
                    {
                        if (FileCompare(f, files[i]))
                        {
                            File.Move(f, f.Replace(@"d:\wechatvideo\1\", @"d:\wechatvideo\delete\"));
                            break;
                        }
                    }
                }
            }
        }

        private bool FileCompare(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (file1 == file2)
            {
                // Return true to indicate that the files are the same.
                return true;
            }

            // Open the two files.
            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);

            // Check the file sizes. If they are not the same, the files 
            // are not the same.
            if (fs1.Length != fs2.Length)
            {
                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                return false;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do
            {
                // Read one byte from each file.
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the success of the comparison. "file1byte" is 
            // equal to "file2byte" at this point only if the files are 
            // the same.
            return ((file1byte - file2byte) == 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            strList.Add("2015-05-03-190019_c30afbd96860.mp4");
            strList.Add("2015-05-03-190054_c30afbd43681.mp4");
            strList.Add("2015-05-06-155757_a59ea0f742611.mp4");
            strList.Add("2015-05-06-151326_9f2de3a673910.mp4");
            strList.Add("2015-05-09-092337_e50a0b176702.mp4");
            strList.Add("2015-05-16-185512_e50a0b122912.mp4");
            strList.Add("2015-05-17-143304_444865445830.mp4");
            strList.Add("2015-05-19-231700_fffbb6d7990.mp4");
            strList.Add("2015-05-22-193321_fffbb6d16870.mp4");
            strList.Add("2015-05-28-205646_c30afbd68840.mp4");
            strList.Add("2015-05-28-205753_c30afbd31771.mp4");
            strList.Add("2015-06-04-201730_e49e8ec8090.mp4");
            strList.Add("2015-06-04-202113_e49e8ec33923.mp4");
            strList.Add("2015-06-04-202645_6b1a1a752064.mp4");
            strList.Add("2015-06-06-120001_df61a6119961.mp4");
            strList.Add("2015-06-06-194141_36668e1139811.mp4");
            strList.Add("2015-06-10-082234_fffbb6d49957.mp4");
            strList.Add("2015-06-11-105629_a59ea0f99967.mp4");
            strList.Add("2015-06-16-202303_e50a0b135070.mp4");
            strList.Add("2015-06-20-163822_9a4ee0727700.mp4");
            strList.Add("2015-06-19-125305_b1fcf8559560.mp4");
            strList.Add("2015-06-27-164639_c30afbd97450.mp4");
            strList.Add("2015-06-28-221419_e50a0b190640.mp4");
            strList.Add("2015-06-30-194055_e50a0b156360.mp4");
            strList.Add("2015-07-03-212245_e50a0b159830.mp4");
            strList.Add("2015-07-05-173939_e50a0b198040.mp4");
            strList.Add("2015-07-14-191603_d9f5a4f37361.mp4");

            strList.Add("2015-07-17-220628_cf48f8188720.mp4");
            strList.Add("2015-07-18-002425_628cfbb55110.mp4");
            strList.Add("2015-07-19-090857_cf48f8174110.mp4");
            strList.Add("2015-07-19-092053_cf48f8132401.mp4");
            strList.Add("2015-07-25-201618_23f300280080.mp4");
            strList.Add("2015-07-25-213732_e50a0b121881.mp4");
            strList.Add("2015-07-26-133912_e50a0b120202.mp4");
            strList.Add("2015-08-01-104524_9f2de3a49666.mp4");
            strList.Add("2015-08-01-202048_e50a0b1863313.mp4");
            strList.Add("2015-08-02-131411_23f300214060.mp4");
            strList.Add("2015-08-04-203537_c7957e475440.mp4");
            strList.Add("2015-08-05-092307_916933272690.mp4");
            strList.Add("2015-08-07-063902_5d3b8b826250.mp4");
            strList.Add("2015-08-08-210049_5d3b8b896215.mp4");
            strList.Add("2015-08-08-223222_dcbd98422806.mp4");
            strList.Add("2015-08-08-223430_dcbd9842947.mp4");
            strList.Add("2015-08-08-225246_dcbd98460908.mp4");
            strList.Add("2015-08-08-230038_dcbd98487209.mp4");
            strList.Add("2015-08-08-233503_dcbd98435060.mp4");
            strList.Add("2015-08-08-233826_9934aac61031.mp4");
            strList.Add("2015-08-18-174649_cf48f8190620.mp4");
            strList.Add("2015-08-18-174724_cf48f8140651.mp4");
            strList.Add("2015-08-18-183738_cf48f8186262.mp4");

            strList.Add("2015-08-20-182641_cf48f8115113.mp4");
            strList.Add("2015-08-20-182758_cf48f8188024.mp4");
            strList.Add("2015-08-20-182803_cf48f8137045.mp4");
            strList.Add("2015-08-20-183016_cf48f8169726.mp4");
            strList.Add("2015-08-20-183109_cf48f8199287.mp4");
            strList.Add("2015-08-25-190014_cf48f8143380.mp4");
            strList.Add("2015-08-25-190100_cf48f812181.mp4");
            strList.Add("2015-08-25-191714_cf48f8140904.mp4");
            strList.Add("2015-08-25-192218_cf48f8189315.mp4");
            strList.Add("2015-08-29-213721_cf48f8115860.mp4");
            strList.Add("2015-09-06-124045_cf48f8156275.mp4");
            strList.Add("2015-09-06-181407_cf48f8177180.mp4");
            strList.Add("2015-09-09-081509_dd89dd196283.mp4");
            strList.Add("2015-09-10-201555_d9f5a4f51962.mp4");
            strList.Add("2015-09-12-144003_cf48f8132830.mp4");
            strList.Add("2015-09-12-152406_e50a0b167081.mp4");
            strList.Add("2015-10-01-122111_680679614920.mp4");
            strList.Add("2015-10-01-141924_b1fcf8540401.mp4");
            strList.Add("2015-10-03-211854_a8279a446610.mp4");
            strList.Add("2015-10-03-211918_a8279a485581.mp4");
            strList.Add("2015-10-04-215453_e50a0b135246.mp4");
            strList.Add("2015-10-07-211109_e50a0b199464.mp4");
            strList.Add("2015-10-09-214909_df61a6196602.mp4");
            strList.Add("2015-10-10-212323_dd89dd134790.mp4");
            strList.Add("2015-10-10-212331_dd89dd115161.mp4");
            strList.Add("2015-10-15-180516_8e8dc9664990.mp4");
            strList.Add("2015-10-16-201136_df61a6166010.mp4");
            strList.Add("2015-10-21-145351_b1fcf8518894.mp4");
            strList.Add("2015-10-21-153315_b1fcf8552845.mp4");
            strList.Add("2015-10-25-101313_444865435761.mp4");
            strList.Add("2015-10-31-082316_e50a0b161651.mp4");
            strList.Add("2015-10-31-123806_9f2de3a609210.mp4");
            strList.Add("2015-11-04-101126_cf48f8161453.mp4");
            strList.Add("2015-11-04-215501_cf48f8116551.mp4");
            strList.Add("2015-11-04-215632_cf48f8125642.mp4");
            strList.Add("2015-11-06-212551_df61a6119111.mp4");
            strList.Add("2015-11-10-212859_c473b09980712.mp4");
            strList.Add("2015-11-10-212955_c473b09586013.mp4");
            strList.Add("2015-11-10-214218_6b1a1a7828414.mp4");
            strList.Add("2015-11-10-214330_57ae6c629015.mp4");
            strList.Add("2015-11-10-215502_c473b09245916.mp4");
            strList.Add("2015-11-12-160602_cf48f81239911.mp4");
            strList.Add("2015-11-12-162935_cf48f81597512.mp4");
            strList.Add("2015-11-13-070725_cf48f8158960.mp4");
            strList.Add("2015-11-13-191838_57ae6c687920.mp4");

            //foreach (string f in strList)
            //{

            //    string fileName = System.IO.Path.GetFileName(f);
            //    if (fileName.Split('.')[0].Length > 12)
            //    {
            //        string fileTargetName = convertFileName(fileName);
            //        string fileTargetPath = f.Replace(fileName, fileTargetName);
            //        File.Move(f, fileTargetPath);
            //    }
            //}

            string[] files = Directory.GetFiles(@"d:\wechatvideo\1\");
            foreach (string f in files)
            {
                if (strList.Contains(f.Replace(@"d:\wechatvideo\1\", ""))) {
                    File.Move(f, f.Replace(@"d:\wechatvideo\1\", @"d:\wechatvideo\1\delete\"));
                    //            break;
                }
                //if()
                //for (int i = 0; i < files.Length; i++)
                //{
                //    if (f != files[i] && File.Exists(f) && File.Exists(files[i]))
                //    {
                //        if (FileCompare(f, files[i]))
                //        {
                //            File.Move(f, f.Replace(@"d:\wechatvideo\1\", @"d:\wechatvideo\delete\"));
                //            break;
                //        }
                //    }
                //}
            }
        }
    }
}
