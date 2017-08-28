#region CLR�汾 4.0.30319.239
// IProjectFactory �ӿ�
// ʱ�䣺2011-11-25 9:41:13
// ���ƣ�IProjectFactory
// ��٣����̹����ӿ�, ���𴴽��ڹ���Doc/View�ṹ
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

namespace TDQS.Contracts
{
    /// <summary>
    /// ���̽ӿڣ������ĵ�
    /// </summary>
    public interface IProject : ISavable, ILockable
    {
        #region ����

        /// <summary>
        /// ��һ���ĵ�������
        /// </summary>
        /// <param name="key"></param>
        void BindDocManager(string key);

        /// <summary>
        /// ����һ���ĵ�����
        /// </summary>
        /// <param name="pathName">�ĵ�·��</param>
        /// <param name="name">�ĵ�����</param>
        /// <param name="spec">�ĵ�������Ϣ</param>
        /// <param name="tempPath">ģ��·��</param>
        /// <returns>�ĵ�����</returns>
        DocInfo CreateDocInfo(string pathName, String name, IShellSpec spec, string tempPath="");

  
        /// <summary>
        /// �����ĵ���Ϣ
        /// </summary>
        /// <param name="pathName"></param>
        /// <returns></returns>
        DocInfo FindDocInfo(string pathName);

        /// <summary>
        /// �Ƴ����ĵ���Ϣ
        /// </summary>
        /// <param name="info"></param>
        void RemoveDocInfo(DocInfo info);

        /// <summary>
        /// ��õ�ǰ����Ĺ��������� 
        /// </summary>
        /// <returns></returns>
        IView GetActiveView();

        /// <summary>
        /// ˢ�²���
        /// </summary>
        void RefreshParms();

        /// <summary>
        /// ��֤���������Ƿ���Ч
        /// </summary>
        /// <param name="pathName">�ĵ�·��</param>
        /// <returns>�Ƿ���Ч</returns>
        bool ValidateDocumentData(string pathName);

        /// <summary>
        /// ��õ�ǰ������ĵ�����
        /// </summary>
        /// <returns></returns>
        IDocument GetActiveDocument();

        #endregion // ����

        #region ����

        /// <summary>
        /// ��ȡΨһʶ����
        /// </summary>
        string ID { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        string ParmsId { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// ���̴�������
        /// </summary>
        System.Nullable<System.DateTime> CreateDate { get; set; }

        /// <summary>
        /// ���̵�ǰ�о���ID
        /// </summary>   
        int PJTId { get; set; }

        /// <summary>
        /// �Ƿ񼤻�
        /// </summary>
        bool Active { get; set; }
        /// <summary>
        /// ·����
        /// </summary>
        string PathName { get; set; }

        /// <summary>
        /// �����µĵ�������(ֻ��)
        /// </summary>   
        List<IElement> ENetworkElements { get; }

        // Start Bug No.[        ]  (��� 2013/7/15 14:18:55) [�ʼ����]
        // ��������:  
        //            
        // �޸�˵��:  
        //            
        // ======================================================= 

        /// <summary>
        /// ��ȡ�Ѿ��򿪵��ĵ��б�
        /// </summary>
        List<IDocument> OpenedDocuments { get; }

        // End Bug No.[        ] (��� 2013/7/15 14:19:06)

        /// <summary>
        /// ��ȡ�ļ���
        /// </summary>
        IEnumerable<DocInfo> Documents { get; }
        /// <summary>
        /// ��ǰ�����ĵ���Ϣ
        /// </summary>
        DocInfo DocInfo { get; set; }

        /// <summary>
        /// ���ݿ����
        /// </summary>
        IDatabase database { get; set; }

        /// <summary>
        /// ���̼�Session
        /// ����20121120����
        /// </summary>
        IORMSessionDecorator Session { get; }


        /// <summary>
        /// �ĵ�������
        /// </summary>
        IDocManager DocManager { get; }

        #endregion // ����

        #region �¼�

        /// <summary>
        /// ����״̬�ı�
        /// </summary>
        event EventHandler ActivedStateChanged;

        /// <summary>
        /// ���̱������
        /// </summary>
        event EventHandler Saved;
        #endregion // �¼�
    }
   
}

