#region CLR�汾 4.0.30319.225
// IPacket �ӿ�
// ʱ�䣺2011-11-21 9:58:19
// ���ƣ����ݰ����䷺�ͽӿ�
// ��٣��޶�������������������ʽ����
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

namespace TDQS
{
    /// <summary>
    /// ���ݰ��ӿ�
    /// </summary>
    public interface IPacket
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ��ȡ�ڲ�����
        /// </summary>
        object Data { get; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }

    /// <summary>
    /// ���ݰ����ͽӿ�
    /// </summary>
    /// <typeparam name="T">��������</typeparam>
    public interface IPacket<T> : IPacket
    {
        #region ����
        #endregion // ����

        #region ����
        /// <summary>
        /// ��ȡ�ڲ�����
        /// </summary>
        new T Data { get; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

