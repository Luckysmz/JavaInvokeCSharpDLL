#region CLR�汾 4.0.30319.239
// DocInfo ��
// ʱ�䣺2012-4-18 11:39:28
// ���ƣ�DocInfo
// ��٣��ĵ���Ϣ��
//
// �����ˣ�����
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TDQS.Contracts
{
    /// <summary>
    /// �ĵ���Ϣ��
    /// </summary>
    public class DocInfo
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public DocInfo()
        {
        }

        #endregion // ���������

        #region ���з���
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        /// <summary>
        /// �ĵ�����
        /// </summary>
        public string Name;

        /// <summary>
        /// �ĵ�·������(ȫ���������ļ���)
        /// </summary>
        public string PathFullName;

        /// <summary>
        /// �ĵ�·����
        /// </summary>
        public string PathName;

        /// <summary>
        /// ����ID
        /// </summary>
        public string DWID;
        
        /// <summary>
        /// ��������
        /// </summary>
        public string DWName;

        /// <summary>
        /// ��������
        /// </summary>
        public string ProjectName;

        /// <summary>
        /// ����ID
        /// </summary>
        public string ProjectID;

        /// <summary>
        /// ��ϵͳ���
        /// </summary>
        public IShellSpec spec;

        /// <summary>
        /// �Ƿ��½��ļ�
        /// </summary>
        public bool flagCreateFile;

        /// <summary>
        /// �ļ���Ϣ
        /// </summary>
        public FileInfo subSystemFile;

        #region ���ݵ���  ����ƽ

        /// <summary>
        /// �Ƿ������رյ���
        /// </summary>
        public bool IsExceptionClose;

        /// <summary>
        /// ���ݵ���ID�б�
        /// </summary>
        public List<string> BackUpFiles;

        /// <summary>
        /// �ۼƻʱ��
        /// </summary>
        public int SumSecounds;

        #endregion

        #endregion // ���Լ���˽�б���

    }
}