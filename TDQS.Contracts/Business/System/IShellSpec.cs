#region CLR�汾 4.0.30319.225
// IShellSpec �ӿ�
// ʱ�䣺2011-12-12 9:41:53
// ���ƣ��ǹ��
// ��٣�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;
using System.Drawing;
using System.ComponentModel.Composition;

namespace TDQS.Contracts
{
    /// <summary>
    /// �ǹ��
    /// </summary>
    public interface IShellSpec
    {
        #region ����
        #endregion // ����

        #region ����

        /// <summary>
        /// ��ȡ���Ŀ¼
        /// </summary>
        string ComponentsDirectory
        {
            get;
        }

        /// <summary>
        /// ��ȡ����
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// ��ȡ���
        /// </summary>
        string ShortName
        {
            get;
        }

        /// <summary>
        /// ��ȡͼ��
        /// </summary>
        Icon Icon
        {
            get;
        }

        /// <summary>
        /// ��ȡСͼ��
        /// </summary>
        Image SmallIcon
        {
            get;
        }

        /// <summary>
        /// ��ȡ��ͼ��
        /// </summary>
        Image LargeIcon 
        { 
            get;
        }

        /// <summary>
        /// ��ȡ���ͼ��
        /// </summary>
        Image UnbanIcon
        {
            get;
        }

        /// <summary>
        /// ��ȡ��ֹͼ��
        /// </summary>
        Image BanIcon
        {
            get;
        }

		/// <summary>
		/// ��ǰ����
		/// </summary>
		string Area
		{
			get;
			set;
		}

		/// <summary>
		/// ��ǰ���
		/// </summary>
		uint Year
		{
			get;
			set;
		}

        /// <summary>
        /// ��ȡĬ���ĵ�����
        /// </summary>
        string DefaultDocName 
        {
            get; 
        }

        /// <summary>
        /// ��ȡ�����ĵ���¼·��
        /// </summary>
        string RecentFilesRecord
        {
            get;
        }

        /// <summary>
        /// ��ȡ��Ӧ���ļ���չ��
        /// </summary>
        string FileExtension
        {
            get;
        }

        /// <summary>
        /// ��ȡ֧�ֵĸ�ʽ
        /// </summary>
        string[] SupportedFormats
        {
            get;
        }

        /// <summary>
        /// ��ȡ�������ʺϵ��ļ���չ��
        /// </summary>
        string SpecVersion { get; }

        /// <summary>
        /// ϵͳģ��·��
        /// </summary>
        string AppTemplatePath
        {
            get;
        }

        /// <summary>
        /// ϵͳ����
        /// </summary>
        byte SubgchtypeID
        {
            get;
        }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }

    /// <summary>
    /// �ǹ��Ԫ����
    /// </summary>
    [MetadataAttribute]
    public class ShellSpecMetadata : Attribute
    {
        /// <summary>
        /// ��ȡ���������Ŀ¼
        /// </summary>
        public string ComponentsDirectory
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ����������
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ü��
        /// </summary>
        public string ShortName
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ������ͼ��
        /// </summary>
        public Icon Icon
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ������Сͼ��
        /// </summary>
        public Image SmallIcon
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ô�ͼ��
        /// </summary>
        public Image LargeIcon
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ���������ͼ��
        /// </summary>
        public Image UnbanIcon
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ý�ֹͼ��
        /// </summary>
        public Image BanIcon
        {
            get;
            set;
        }

		/// <summary>
		/// ��ǰ����
		/// </summary>
		public string Area
		{
			get;
			set;
		}

		/// <summary>
		/// ��ǰ���
		/// </summary>
		public int Year
		{
			get;
			set;
		}

        /// <summary>
        /// ��ȡ������Ĭ���ĵ�����
        /// </summary>
        public string DefaultDocName
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�����ý����ĵ���¼·��
        /// </summary>
        public string RecentFilesRecord
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ�������ʺϵ��ļ���չ��
        /// </summary>
        public string FileExtension
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ������֧�ֵĸ�ʽ
        /// </summary>
        public string[] SupportedFormats
        {
            get;
            set;
        }

        /// <summary>
        /// ��ϵͳ���
        /// </summary>
        public long ID
        {
            get;
            set;
        }

    }

    /// <summary>
    /// �ǹ��Ԫ����View
    /// </summary>
    public interface IShellSpecMetadataView
    {
        /// <summary>
        /// ��ȡ���������Ŀ¼
        /// </summary>
        string ComponentsDirectory { get; }
        /// <summary>
        /// ��ȡ����������
        /// </summary>
        string Name { get; }
        /// <summary>
        /// ��ȡ�����ü��
        /// </summary>
        string ShortName { get; }
        /// <summary>
        /// ��ȡ������ͼ��
        /// </summary>
        Icon Icon { get; }
        /// <summary>
        /// ��ȡ������Сͼ��
        /// </summary>
        Image SmallIcon { get; }
        /// <summary>
        /// ��ȡ�����ô�ͼ��
        /// </summary>
        Image LargeIcon { get; }
        /// <summary>
        /// ��ȡ���ͼ��
        /// </summary>
        Image UnbanIcon { get; }
        /// <summary>
        /// ��ȡ��ֹͼ��
        /// </summary>
        Image BanIcon { get; }
		/// <summary>
		/// ��ǰ����
		/// </summary>
		string Area
		{
			get;
			//set;
		}
		/// <summary>
		/// ��ǰ���
		/// </summary>
		int Year
		{
			get;
			//set;
		}
        /// <summary>
        /// ��ȡĬ���ĵ�����
        /// </summary>
        string DefaultDocName { get; }
        /// <summary>
        /// ��ȡ�����ĵ���¼·��
        /// </summary>
        string RecentFilesRecord { get; }
        /// <summary>
        /// ��ȡ�ʺϵ��ļ���չ��
        /// </summary>
        string FileExtension { get; }
        /// <summary>
        /// ��ȡ֧�ֵĸ�ʽ
        /// </summary>
        string[] SupportedFormats { get; }
        /// <summary>
        /// ��ϵͳ���
        /// </summary>
        long ID { get; }
      }
}

