#region CLR�汾 4.0.30319.17379
// IAttributeTrigger �ӿ�
// ʱ�䣺2012/4/14 11:19:31
// ���ƣ�IAttributeTrigger
// ��٣�Ԫ�����Դ������ӿ�
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
    /// Ԫ�����Դ������ӿ�
    /// </summary>
    public interface IAttributeTrigger
    {
        #region ����
        
        ///// <summary>
        ///// �õ���ѡ���ַ���
        ///// </summary>
        ///// <param name="attrName"></param>
        ///// <returns></returns>
        //string GetListString(IElement ele, string attrName);

        ///// <summary>
        ///// ���ݴ���������޸��������ֵ
        ///// </summary>
        ///// <param name="attrName"></param>
        ///// <param name="refresh"></param>
        //void AlterAttributeValue(IElement ele, string attrName, bool refresh = true);
        
        #endregion // ����

        #region ����

        /// <summary>
        /// �õ��������Ƿ��޸��������
        /// </summary>
        bool AlterRelativeAttributes
        { 
            get; 
            set; 
        }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

