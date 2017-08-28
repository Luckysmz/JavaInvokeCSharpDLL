#region CLR�汾 4.0.30319.239
// IToolBox �ӿ�
// ʱ�䣺2011-11-28 10:37:39
// ���ƣ�������
// ��٣�ʵ�ֹ�����ؼ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TDQS.Contracts
{
	/// <summary>
	/// IToolBox �ӿ�
	/// </summary>
	public interface IToolBox
	{
		#region ����

		/// <summary>
		/// ���湤��������
		/// </summary>
		/// <param name="path">�����ļ�·��</param>
		void SaveConfig(string path = null);
		
		/// <summary>
		/// ˢ�¹��������
		/// </summary>
		/// <param name="path">�����ļ�·��</param>
		void RebuildControl(string path = null);

        /// <summary>
        /// �������д򿪵Ĺ��ߵ�������
        /// </summary>
        void SaveAllConfig();

        /// <summary>
        /// ˢ�����д򿪵Ĺ��ߵĽ���
        /// </summary>
        void RebuildAllControl();

		/// <summary>
		/// �Ƴ���Ŀ
		/// </summary>
		/// <param name="ID">��ĿID</param>
		void RemoveItem(string ID);

        /// <summary>
        /// �Ƴ���Ŀ(���������������ļ�)
        /// </summary>
        /// <param name="ID">��ĿID</param>
        void RemoveItemCascade(string ID);

        /// <summary>
        /// ������Ŀ������Ŀ����������ӣ� ���������������ļ���
        /// </summary>
        /// <param name="item">���������Ŀ</param>
        /// <param name="bandID">��Ŀ�������뵽�ĸ�������</param>
        /// <param name="errText">������ʾ��Ϣ</param>
        /// <param name="checkNameUnique">�Ƿ�������Ψһ��</param>
        /// <returns>�����Ƿ�ɹ�</returns>
        bool SaveItemCascade(IToolBoxItem item, string bandID, out string errText, bool checkNameUnique = false);

        /// <summary>
        /// ��ȡһ����������Ŀ
        /// </summary>
        /// <param name="ID">��ĿID</param>
        /// <returns>��������Ŀ</returns>
        IToolBoxItem GetItem(string ID);

        /// <summary>
        /// ������Ŀ������Ŀ����������ӣ�
        /// </summary>
        /// <param name="item">���������Ŀ</param>
        /// <param name="bandID">��Ŀ�������뵽�ĸ������£�����ӷ�����ò���������</param>
        /// <returns>�����Ƿ�ɹ�</returns>
        bool SaveItem(IToolBoxItem item, string bandID);

        /// <summary>
        /// �õ����������ʵ��
        /// </summary>
        /// <returns>���������ʵ��</returns>
        IToolBox GetNewInstance();

        /// <summary>
        /// ���»�������
        /// </summary>
        /// <param name="item"></param>
        /// <param name="bandID"></param>
        void UpdateCache(IToolBoxItem item, string bandID);

		#endregion // ����

		#region ����
		/// <summary>
		/// ��ȡ�ؼ�����
		/// </summary>
		UserControl Control 
		{
			get; 
		}

		/// <summary>
		/// �ı���ͼ
		/// </summary>
		ToolBoxViewState View
		{
			get;
			set;
		}

		/// <summary>
		/// ͼ�귽ʽ
		/// </summary>
		ToolBoxIconView IconView
		{
			get;
			set;
		}

		/// <summary>
		/// ��������Ŀ����
		/// </summary>
		ToolBoxItemCollection Items
		{
			get;
		}

        /// <summary>
        /// �����ļ�·��
        /// </summary>
        string ConfigPath
        {
            get;
        }

        /// <summary>
        /// ������û�Ԫ���б�
        /// </summary>
        bool EnableList
        {
            get;
            set;
        }

        /// <summary>
        /// Emf�ļ�·��
        /// </summary>
        string EmfRootPath
        {
            get;
            set;
        }

		#endregion // ����

		#region �¼�
		#endregion // �¼�
	}

	/// <summary>
	/// ��������ͼö��
	/// </summary>
	public enum ToolBoxViewState
	{
        /// <summary>
        /// ͨ����ͼ
        /// </summary>
		Normal = 0,

        /// <summary>
        /// ����ͼ
        /// </summary>
		Tree
	}

	/// <summary>
	/// ������ͼ��ö��
	/// </summary>
	public enum ToolBoxIconView
	{
        /// <summary>
        /// 16 * 16
        /// </summary>
		Small = 0,

        /// <summary>
        /// 32 * 32
        /// </summary>
		Big
	}
}

