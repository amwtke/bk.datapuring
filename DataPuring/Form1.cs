using BK.Model.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPuring
{
    public partial class Form1 : Form
    {
        public static readonly string GetHost = @"http://wechat.51science.cn/weixinapi/";//@"http://localhost:58076/weixinapi/";//
        private static List<Guid> _uuids;
        private static List<UserAcademic> _bindList;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = GetHost;
        }
        protected override void OnLoad(EventArgs e)
        {
            init();
            base.OnLoad(e);
        }
        private async void init()
        {
            _uuids = await Helper.GetUUIDs();
            lb_count.Text = _uuids.Count().ToString();
            if(_uuids.Count>0)
            {
                _bindList = await Helper.GetUserAcademicByUuid(_uuids[0]);
                dataGridView1.DataSource = _bindList;
            }

            PreProcess();
        }

        private void PreProcess()
        {
            int count = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.None);
            List<UserAcademic> added = new List<UserAcademic>();
            

            for (int i=0;i<count;i++)
            {
                UserAcademic item = dataGridView1.Rows[i].DataBoundItem as UserAcademic;
                if(!string.IsNullOrEmpty(item.Association) && string.IsNullOrEmpty(item.AssociationPost))
                {
                    string[] asses = item.Association.Trim().Split(new char[] { '；', '、', '，','和','。',';'});
                    if(asses.Length>1)
                    {
                        foreach(string s in asses)
                        {
                            if (string.IsNullOrEmpty(s))
                                continue;

                            UserAcademic tmp = new UserAcademic();
                            tmp.AccountEmail_uuid = item.AccountEmail_uuid;
                            tmp.Tutor = item.Tutor;
                            tmp.Association = s;
                            if (s.EndsWith("委员") || s.EndsWith("会员") || s.EndsWith("理事") || s.EndsWith("成员") || s.EndsWith("组长"))
                            {
                                tmp.AssociationPost = s.Substring(s.Length - 2, 2);
                                tmp.Association = tmp.Association.Substring(0, s.Length - 2);
                            }

                            if (s.EndsWith("高级会员") || s.EndsWith("评审专家"))
                            {
                                tmp.AssociationPost = s.Substring(s.Length - 4, 4);
                                tmp.Association = s.Substring(0, s.Length - 4);
                            }

                            if (s.EndsWith("副主任"))
                            {
                                tmp.AssociationPost = s.Substring(s.Length - 3, 3);
                                tmp.Association = s.Substring(0, s.Length - 3);
                            }
                            added.Add(tmp);
                        }
                    }
                    else
                    {


                        if (item.Association.EndsWith("高级会员") || item.Association.EndsWith("副理事长") || item.Association.EndsWith("常务理事") || item.Association.EndsWith("副秘书长") || item.Association.EndsWith("评审专家")|| item.Association.EndsWith("专家顾问"))
                        {
                            item.AssociationPost = item.Association.Substring(item.Association.Length - 4, 4);
                            item.Association = item.Association.Substring(0, item.Association.Length - 4);
                        }

                        if (item.Association.EndsWith("副主任") || item.Association.EndsWith("理事长") || item.Association.EndsWith("秘书长")|| item.Association.EndsWith("副会长"))
                        {
                            item.AssociationPost = item.Association.Substring(item.Association.Length - 3, 3);
                            item.Association = item.Association.Substring(0, item.Association.Length - 3);
                        }

                        if (item.Association.EndsWith("委员") || item.Association.EndsWith("会员") || item.Association.EndsWith("理事") || item.Association.EndsWith("成员") || item.Association.EndsWith("组长") || item.Association.EndsWith("专家"))
                        {
                            item.AssociationPost = item.Association.Substring(item.Association.Length - 2, 2);
                            item.Association = item.Association.Substring(0, item.Association.Length - 2);
                        }
                    }
                }

                if (!string.IsNullOrEmpty(item.Fund) && string.IsNullOrEmpty(item.FundPost))
                {
                    string[] asses = item.Fund.Trim().Split(new char[] { '；', '、', '，',';' });
                    if (asses.Length > 1)
                    {
                        foreach (string s in asses)
                        {
                            if (string.IsNullOrEmpty(s))
                                continue;

                            UserAcademic tmp = new UserAcademic();
                            tmp.AccountEmail_uuid = item.AccountEmail_uuid;
                            tmp.Tutor = item.Tutor;
                            tmp.Fund = s;

                            if (s.EndsWith("通讯评审专家") || s.EndsWith("同行评议专家"))
                            {
                                tmp.FundPost = s.Substring(s.Length - 6, 6);
                                tmp.Fund = s.Substring(0, s.Length - 6);
                            }
                            if (s.EndsWith("评审专家"))
                            {
                                tmp.FundPost = s.Substring(s.Length - 4, 4);
                                tmp.Fund = s.Substring(0, s.Length - 4);
                            }

                            added.Add(tmp);
                        }
                    }
                    else
                    {
                        if (item.Fund.Trim().EndsWith("通讯评审专家")|| item.Fund.Trim().EndsWith("匿名评审专家") || item.Fund.Trim().EndsWith("同行评议专家"))
                        {
                            item.FundPost = item.Fund.Substring(item.Fund.Length - 6, 6);
                            item.Fund = item.Fund.Substring(0, item.Fund.Length - 6);
                        }

                        if(item.Fund.Trim().EndsWith("项目评审人"))
                        {
                            item.FundPost = item.Fund.Substring(item.Fund.Length - 5, 5);
                            item.Fund = item.Fund.Substring(0, item.Fund.Length - 5);
                        }
                        if (item.Fund.Trim().EndsWith("评审专家")|| item.Fund.Trim().EndsWith("会评专家"))
                        {
                            item.FundPost = item.Fund.Substring(item.Fund.Length - 4, 4);
                            item.Fund = item.Fund.Substring(0, item.Fund.Length - 4);
                        }
                    }
                }

                if (!string.IsNullOrEmpty(item.Magazine) && string.IsNullOrEmpty(item.MagazinePost))
                {
                    string[] asses = item.Magazine.Trim().Split(new char[] { '；', '、', '，' });
                    if (asses.Length > 1)
                    {
                        foreach (string s in asses)
                        {
                            if (string.IsNullOrEmpty(s))
                                continue;

                            UserAcademic tmp = new UserAcademic();
                            tmp.AccountEmail_uuid = item.AccountEmail_uuid;
                            tmp.Tutor = item.Tutor;
                            tmp.Magazine = s;

                            if (s.EndsWith("审稿人"))
                            {
                                tmp.MagazinePost = s.Substring(s.Length - 3, 3);
                                tmp.Magazine = s.Substring(0, s.Length - 3);
                            }
                            if (s.EndsWith("编委"))
                            {
                                tmp.MagazinePost = s.Substring(s.Length - 2, 2);
                                tmp.Magazine = s.Substring(0, s.Length - 2);
                            }

                            added.Add(tmp);
                        }
                    }
                    else
                    {
                        if (item.Magazine.EndsWith("同行评议人"))
                        {
                            item.MagazinePost = item.Magazine.Substring(item.Magazine.Length - 5, 5);
                            item.Magazine = item.Magazine.Substring(0, item.Magazine.Length - 5);
                        }
                        if (item.Magazine.EndsWith("审稿人"))
                        {
                            item.MagazinePost = item.Magazine.Substring(item.Magazine.Length - 3, 3);
                            item.Magazine = item.Magazine.Substring(0, item.Magazine.Length - 3);
                        }
                        if (item.Magazine.EndsWith("编委"))
                        {
                            item.MagazinePost = item.Magazine.Substring(item.Magazine.Length - 2, 2);
                            item.Magazine = item.Magazine.Substring(0, item.Magazine.Length - 2);
                        }
                    }
                }
            }

            if(added.Count>0)
            {
                _bindList.AddRange(added);
                rebind();
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex>=0)
            {
                object o = dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                cell.Style.BackColor = Color.Yellow;


                string s = dataGridView1[e.ColumnIndex, e.RowIndex].Value as string;
                if (!string.IsNullOrEmpty(s))
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = s.Trim();
            }
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("会刷新搜索修改的记录，确定？","注意",MessageBoxButtons.OKCancel)== DialogResult.OK)
                init();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            UserAcademic tmp = new UserAcademic();
            var selected = dataGridView1.Rows[0].DataBoundItem as UserAcademic;
            tmp.AccountEmail_uuid = selected.AccountEmail_uuid;
            tmp.Tutor = selected.Tutor;
            _bindList.Add(tmp);
            rebind();
        }

        private void rebind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _bindList;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            UserAcademic tmp = new UserAcademic();
            if (dataGridView1.SelectedRows.Count <= 0)
                return;
            var selected = dataGridView1.SelectedRows[0].DataBoundItem as UserAcademic;
            if (selected.Id > 0)
                return;
            _bindList.Remove(selected);
            rebind();
        }

        private async void bt_upload_Click(object sender, EventArgs e)
        {
            bt_add.Enabled = false;
            bt_delete.Enabled = false;
            bt_refresh.Enabled = false;
            bt_upload.Enabled = false;
            foreach (var v in _bindList)
            {
                await Helper.SaveOrUpdateAcademic(v);
            }
            MessageBox.Show("上传完毕", "消息", MessageBoxButtons.OK);
            init();
            bt_add.Enabled = true;
            bt_delete.Enabled = true;
            bt_refresh.Enabled = true;
            bt_upload.Enabled = true;
        }

        private async void tb_uuid_TextChanged(object sender, EventArgs e)
        {
            Guid uuid;
            if (Guid.TryParse(tb_uuid.Text, out uuid) && _uuids.Contains(uuid))
            {
                var ret = await Helper.GetUserAcademicByUuid(uuid);
                _bindList = ret;
                rebind();
            }
            else
            {
                _bindList = null;
                rebind();
            }
        }
    }
}
