#region CLR�汾 4.0.30319.239
// IResourceProvider �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IResourceProvider 
// ��٣���Դ�ṩ�߽ӿ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Reflection;

namespace TDQS.Contracts
{
    /// <summary>
    /// ��Դ�ṩ�߽ӿ�
    /// </summary>
    public interface IResourceProvider
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ��Դ��ʩ����
        /// </summary>
        string BaseName { get; }

        /// <summary>
        /// ��������
        /// </summary>
        Assembly AssemblyObj { get; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

