#region CLR�汾 4.0.30319.225
// IConfigService �ӿ�
// ʱ�䣺2011-11-16 11:08:29
// ���ƣ����÷���
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

namespace TDQS.Contracts
{
    /// <summary>
    /// ���÷���ӿ�
    /// </summary>
    public interface IConfigService : IService
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ��ȡ���ò�����
        /// </summary>
        IConfigHandler ConfigHandler
        {
            get;
        }

        /// <summary>
        /// ��ȡ���ù�Ӧ��
        /// </summary>
        IConfigProvider ConfigProvider
        {
            get;
        }

        /// <summary>
        /// ��ȡĿ¼������
        /// </summary>
        IPathHandler PathHandler
        {
            get; 
        }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

