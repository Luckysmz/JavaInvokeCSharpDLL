#region CLR�汾 4.0.30319.239
// IDocument �ӿ�
// ʱ�䣺2011-11-23 14:08:59
// ���ƣ�IDocument
// ��٣��ĵ���ӿڣ������ĵ���ʵ�ָýӿ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
// 2011/12/26 15:07:57, ������, ɾ�����ơ�·�����Ƿ񱻱༭���Ƿ񼤻�ķ������������ơ�·�����Ƿ񱻱༭���Ƿ񼤻������
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Collections.ObjectModel;

namespace TDQS.Contracts
{
    /// <summary>
    /// �ĵ����ݽӿ�
    /// </summary>
    public interface IDocument : ISavable, ILockable
    {
        #region ����
        /// <summary>
        /// ����ͼ�б�������һ������������
        /// </summary>
        /// <param name="view"></param>
        void AddView(IView view);
        /// <summary>
        /// ����ͼ�б����Ƴ�һ����ͼ���� 
        /// </summary>
        /// <param name="view"></param>
        void RemoveView(IView view);
        /// <summary>
        /// �Ƴ�����View����
        /// </summary>
        void RemoveAllViews();
        /// <summary>
        /// ����������ͼ����
        /// </summary>
        void UpdateAllViews();
        /// <summary>
        /// ��ȡ��ǰ�������ͼ����
        /// </summary>
        /// <returns></returns>
        IView GetActiveView();
        /// <summary>
        /// �������ֲ�����ͼ
        /// </summary>
        /// <param name="viewname"></param>
        /// <returns></returns>
        IView FindView(string viewname);
        /// <summary>
        /// �ĵ������ʼ��
        /// </summary>
        void Initialize();
        /// <summary>
        /// ��ʼ������Դ
        /// </summary>
        void InitData();
        /// <summary>
        /// �ر�����Դ
        /// </summary>
        void CloseData();
        /// <summary>
        /// ��������Դ
        /// </summary>
        void UpdateData();
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="di"></param>
        /// <returns></returns>
        Boolean CopyData(DocInfo di);
        /// <summary>
        /// ����ĳһ��View
        /// </summary>
        /// <param name="view">view</param>
        void SetActiveView(IView view);
       
        #endregion // ����

        #region ����
        /// <summary>
        /// ����
        /// </summary>
        IProject Project { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        IShellSpec Spec { get; set; }
        /// <summary>
        /// ·����
        /// </summary>
        string PathName { get; set; }
        /// <summary>
        /// ��ͼȫ·��
        /// </summary>
        string MapPath { get; }
        /// <summary>
        /// �Ƿ񱻱༭
        /// </summary>
        bool Modified { get; set; }
        /// <summary>
        /// �Ƿ񼤻�
        /// </summary>
        bool Active { get; set; }
        /// <summary>
        /// ��ȡ��������ͼ����
        /// </summary>
        ReadOnlyCollection<IView> Views { get; }

        /// <summary>
        /// ����
        /// </summary>
        IElement ENetworkElement 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ���ݿ����
        /// </summary>
        IDatabase Database 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ��ȡ�������ĵ�ֻ������
        /// </summary>
        Boolean ReadOnly
        {
            get;
            set;
        }

        /// <summary>
        /// ��עҵ��ӿ�
        /// </summary>
        INoteBuilder NoteBuilder
        {
            get;
            set;
        }

        /// <summary>
        /// �ĵ���Ϣ
        /// </summary>
        DocInfo DocInfo
        {
            get;
            set;
        }

        /// <summary>
        /// �ĵ�������
        /// </summary>
        IDocManager DocManager
        {
            get;
            set;
        }


        /// <summary>
        /// �㷨���ֵ�
        /// </summary>
        Dictionary<string,bool> AlgorLockerDic { get; set; }

        /// <summary>
        /// ������������ID
        /// 20140222 �ɿ��԰汾����
        /// </summary>
        string ParameterID { get; set; } 

        #endregion // ����
        
        #region �¼�
 
        /// <summary>
        /// �ĵ�������󴥷����¼�
        /// </summary>
        event ActiveEventHandler OnActive;
        /// <summary>
        /// �ر�����Դ�����󴥷����¼�
        /// </summary>
        event CloseDataHandler OnCloseData;
        /// <summary>
        /// ��������Դ�󴥷����¼�
        /// </summary>
        event UpdateDataHandler OnUpdateData;
        #endregion // �¼�

    }
    /// <summary>
    /// �ĵ������¼�����
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void ActiveEventHandler(IDocument sender, EventArgs e);
    /// <summary>
    /// �ر�������Դ�¼�����
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void CloseDataHandler(IDocument sender, EventArgs e);
    /// <summary>
    /// ����������Դ�¼�����
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void UpdateDataHandler(IDocument sender, EventArgs e);

}

