#region CLR�汾 4.0.30319.17379
// IWideAreaOptions �ӿ�
// ʱ�䣺2012/06/07 15:32:26
// ���ƣ�IWideAreaOptions
// ��٣����������ӿ�
//
// �����ˣ�������
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
    /// ���������ӿ�
    /// </summary>
    public interface IWideAreaOptions
    {
        #region ����
        /// <summary>
        /// �ж�ĳԪ���Ƿ��ڸô�����Χ��
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool ElementInWideArea(IElement element);

        /// <summary>
        /// ɾ��ָ��Ԫ���ͷ����Ĺ�����ϵ
        /// ����2013.2.16�޸ģ�ȥ������document
        /// </summary>
        /// <param name="element">Ԫ��</param>
        void RemoveRelations(IElement element);

        /// <summary>
        /// ����Ԫ����ϵ
        /// ����2013.2.16�޸ģ�ȥ������document
        /// </summary>
        /// <param name="element">Ԫ��</param>
        void AddRelation(IElement element);
        /// <summary>
        /// �ж�Ԫ���Ƿ��ܺʹ�����������
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool ElementRelativeWideArea(IElement element);

        /// <summary>
        /// ɾ���÷����͸÷�����Ԫ���Ĺ�����ϵ
        /// ����2013.2.16�޸ģ�ȥ������document
        /// </summary>
        void RemoveAllRelations();
        /// <summary>
        /// �������ڵ�Ԫ����ӵ������Ӷ��󼯺���
        /// ����2013.2.16�޸ģ�ȥ������document
        /// </summary>
        /// <returns>���</returns>
        List<IElement> GetElements();

        #endregion // ����

        #region ����

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

