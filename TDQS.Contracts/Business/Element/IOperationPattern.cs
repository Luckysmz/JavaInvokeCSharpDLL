#region CLR�汾 4.0.30319.261
// IOperationPattern �ӿ�
// ʱ�䣺2012/4/14 15:25:10
// ���ƣ�����ģʽ��
// ��٣��ܸ˶��ߡ�ȥ�����ߵ�Ԫ������ģʽ�Ľӿ�
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
    /// ����ģʽ��
    /// </summary>
    [Obsolete("��� 2013-10-24 ������ȷ�ϴ˽ӿڱ��Ϊ��Ч")]
    public interface IOperationPattern
    {
        #region ����
        /// <summary>
        /// �������
        /// </summary>
        /// <returns></returns>
        bool Operate();
        /// <summary>
        /// �������
        /// </summary>
        /// <returns></returns>
        bool OppositeOperate();
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

