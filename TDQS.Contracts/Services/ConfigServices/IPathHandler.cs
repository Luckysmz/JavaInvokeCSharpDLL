#region CLR�汾 4.0.30319.239
// IPathServicesHandler �ӿ�
// ʱ�䣺2011/11/16 10:43:52
// ���ƣ�
// ��٣�
//
// �����ˣ�����ΰ
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
    /// Ŀ¼��������
    /// </summary>
    public interface IPathHandler
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ��ȡ��Ŀ¼
        /// </summary>
        string BaseDirectory
        {
            get;
        }
        /// <summary>
        /// �����ļ�·��
        /// </summary>
        string AppConfigPath
        {
            get;
        }
        /// <summary>
        /// �����ļ�·��
        /// </summary>
        string AppDataPath
        {
            get;
        }
        /// <summary>
        /// ģ��·��
        /// </summary>
        string AppTemplatePath
        {
            get;
        }
        /// <summary>
        /// ����ģ��·��
        /// </summary>
        string AppDWTemplatePath
        {
            get;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

