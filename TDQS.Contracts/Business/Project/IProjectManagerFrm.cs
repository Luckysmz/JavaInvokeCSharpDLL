#region CLR�汾 4.0.30319.269
// IProjectManagerFrm �ӿ�
// ʱ�䣺2012-5-17 8:51:03
// ���ƣ�IProjectManagerFrm
// ��٣����̹���������
//
// �����ˣ�����
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
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
    /// ���̹���������ӿ�
    /// </summary>
    public interface IProjectManagerFrm
    {
        #region ����
        /// <summary>
        ///�򿪹���
        /// </summary>
        /// <param name="projectFile">�����ļ�</param>
        IProject OpenProject(string projectFile);

        /// <summary>
        /// ����ϵͳ�ļ�
        /// </summary>
        /// <param name="subFile">��ϵͳ�ļ�</param>
        void OpenFile(string subFile);

        /// <summary>
        /// �½�����
        /// </summary>
        /// <param name="fileName">�����ļ���</param>
        /// <param name="specs">���</param>
        void NewFile(string fileName, IEnumerable<IShellSpec> specs);

        /// <summary>
        /// �½���ϵͳ�ļ�
        /// </summary>
        /// <param name="fileName">�����ļ���</param>
        /// <param name="spec">��ϵͳ���</param>
        /// <param name="initialName">��ʼ����</param>
        void NewFile(string fileName, IShellSpec spec, string initialName);

        /// <summary>
        /// �½���ϵͳ�ļ�
        /// </summary>
        /// <param name="project">���̶���</param>
        /// <param name="spec">��ϵͳ���</param>
        /// <param name="initialName">��ʼ����</param>
        void NewFile(IProject project, IShellSpec spec, string initialName);

        /// <summary>
        /// �رչ���
        /// </summary>
        /// <param name="fileName">�ļ�����</param>
        void CloseFile(string fileName);

        /// <summary>
        /// ����ļ�
        /// </summary>
        /// <param name="fileName">�ļ�����</param>
        void SaveAsFile(string fileName);

        /// <summary>
        /// ����ļ�
        /// </summary>
        /// <param name="fileName">�ļ�����</param>
        void SaveAsENet(string fileName);

        /// <summary>
        /// ����ʷ���ݵ���
        /// ���ߣ�����ƽ
        /// </summary>
        /// <param name="Project">��ǰ����</param>
        /// <param name="OrgCnpFilePath">ԭʼ����·��</param>
        /// <param name="itemName">���ݵ�������</param>
        /// <param name="itemCode">���ݵ�����ʶ</param>
        /// <param name="itemPath">���ݵ���·��</param>
        void OpenBackUpFile(String specId, IProject Project, string OrgCnpFilePath, string itemName, string itemCode, string itemPath);

        /// <summary>
        /// ����Ƿ���Դ�
        /// </summary>
        /// <param name="ErrorMessage">������Ϣ</param>
        /// <returns>�����Ƿ���Դ�</returns>
        bool canOpen(out string ErrorMessage);

        #endregion // ����

        #region ����
        /// <summary>
        /// ��ȡ��ѡ�еĹ�����
        /// </summary>
        IProject SelectedProject
        {
            get;
        }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

