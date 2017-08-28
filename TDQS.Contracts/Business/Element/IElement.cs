#region CLR�汾 4.0.30319.239
// IElement �ӿ�
// ʱ�䣺2011-11-9 16:49:33
// ���ƣ�IElement �ӿ�
// ��٣�����Ԫ������ʵ�ֵĽӿ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		        �޸���		    ����

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// Ԫ���ӿ�
    /// </summary>
    public interface IElement : ICloneable,INotify
    {
        #region ����

        /// <summary>
        /// ����
        /// </summary>
        /// <returns>��ǰԪ���ĸ���</returns>
        IElement Copy();

        #endregion // ����

        #region ����
        /// <summary>
        /// ���ƶ���
        /// </summary>
        IDrawObject DrawObject
        {
            get;
            set;
        }

        /// <summary>
        /// Ԫ����ֵ��ID
        /// </summary>
        int Index 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Ԫ���ַ���ID
        /// </summary>
        string ID 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Ԫ������
        /// </summary>
        string Name 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Ԫ������
        /// </summary>
        ElementType ElementType 
        { 
            get; 
        }

        /// <summary>
        /// ��Ԫ������
        /// </summary>
        IElement ParentElement
        {
            get;
            set;
        }

        /// <summary>
        /// Ԫ���ĸ���ID
        /// </summary>
        string ParentID 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// �Ƿ������Ԫ��
        /// </summary>
        bool HasChild 
        { 
            get; 
            set; 
        }
    
        /// <summary>
        /// ��ѹ�ȼ�
        /// </summary>
        double Dydj 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ���ڵ�Ԫ������
        /// </summary>
        IElement RootElement
        {
            get;
            set;
        }

        /// <summary>
        /// ����ID
        /// </summary>
        string RootElementID 
        { 
            get;
            set; 
        }

        /// <summary>
        /// ��ǩ
        /// </summary>
        object Tag
        {
            get;
            set;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

