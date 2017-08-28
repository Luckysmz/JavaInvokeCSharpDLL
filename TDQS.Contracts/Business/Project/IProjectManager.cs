#region CLR�汾 4.0.30319.239
// IProjectManager �ӿ�
// ʱ�䣺2012/2/19 14:30:14
// ���ƣ�����ϵͳ�򿪵Ĺ���
// ��٣�
//
// �����ˣ�����ΰ
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
// 2013-6-6     ���      �޸�Bug NO.[Z34#-b-510]
//                          ��ӷ���void ReleaseProject(IProject project);
// --------------------------------------------------------


#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// ����ϵͳ�򿪵Ĺ���
    /// </summary>
    public interface IProjectManager : IDisposable
    {
        #region ����
        /// <summary>
        /// ���ù���Ϊ����״̬
        /// </summary>
        /// <param name="doc"></param>
        void SetActiveProject(IProject project);
        /// <summary>
        /// ����һ�����̶���
        /// </summary>
        /// <param name="DocName"></param>
        /// <returns></returns>
        IProject CreateProject(string PathName);

        /// <summary>
        /// ���������½�һ������
        /// </summary>
        /// <param name="name">����</param>
        /// <returns>���̶���</returns>
        IProject CreateProjectByName(string name);

        /// <summary>
        /// ����һ�����̶���
        /// </summary>
        /// <param name="PathName"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        IProject CreateProject(string PathName, string ID);
        /// <summary>
        /// ���һ���Ѵ��ڵĹ��̶���
        /// </summary>
        /// <param name="doc"></param>
        void AddProject(IProject project);
        /// <summary>
        /// ͨ�����������ж��Ƿ����
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool HasProject(string PathName);
        /// <summary>
        /// ͨ���������Ʋ��ҹ���
        /// </summary>
        /// <param name="pathName"></param>
        /// <returns></returns>
        IProject FindProject(string pathName);
        /// <summary>
        /// ͨ���ĵ���Ϣ���ҹ���
        /// </summary>
        /// <param name="info">�ĵ���Ϣ</param>
        /// <returns>���̶���</returns>
        IProject FindProject(DocInfo info);        
        /// <summary>
        /// �Ƿ����Document
        /// </summary>
        /// <param name="pathName"></param>
        /// <returns></returns>
        bool HasDocument(string pathName);
		/// <summary>
		/// ���Ұ���CNPX��Document
		/// </summary>
		/// <param name="pathName"></param>
		/// <returns></returns>
		IDocument FindCNPXDocument(string FileExtetion);
        /// <summary>
        /// ��ѯDocument
        /// </summary>
        /// <param name="pathName"></param>
        /// <returns></returns>
        IDocument FindDocument(string pathName);
        /// <summary>
        /// �����Ӧ��Project
        /// </summary>
        /// <param name="pathName"></param>
        void SetActiveProject(string pathName);
        /// <summary>
        /// �����Ӧ��Document
        /// </summary>
        /// <param name="pathName"></param>
        void SetActiveDocument(string pathName);
        /// <summary>
        /// �ر�һ������
        /// </summary>
        /// <param name="doc"></param>
        void CloseProject(IProject project);
        /// <summary>
        /// �ͷ�һ������
        /// </summary>
        /// <param name="project">����</param>
        void ReleaseProject(IProject project);
        /// <summary>
        /// �ر����й���
        /// </summary>
        void CloseAllProjects();
        /// <summary>
        /// ��õ�ǰ����Ĺ��̶���
        /// </summary>
        /// <returns></returns>
        IProject GetActiveProject();
        /// <summary>
        /// �Ƴ�һ������
        /// </summary>
        /// <param name="project"></param>
        void RemoveProject(IProject project);
        
        #endregion // ����

        #region ����

        /// <summary>
        /// ��ȡ������Ĺ�������
        /// </summary>
        int Count
        {
            get;
        }

        /// <summary>
        /// ��ȡ������Ĺ�������
        /// </summary>
        IEnumerable<IProject> Projects
        {
            get;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

