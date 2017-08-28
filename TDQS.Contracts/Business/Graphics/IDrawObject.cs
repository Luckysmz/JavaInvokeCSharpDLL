#region CLR�汾 4.0.30319.239
// IDrawObject �ӿ�
// ʱ�䣺2011-11-8 16:03:24
// ���ƣ�IDrawObject
// ��٣����л��ƶ������ʵ�ֵĽӿ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
//
//
#endregion
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Xml;
using System.ComponentModel;

namespace TDQS.Contracts
{
    /// <summary>
    /// ���л��ƶ������ʵ�ֵĽӿ�
    /// </summary>
    public interface IDrawObject : ICloneable,INotify
    {
        #region ����
        /// <summary>
        /// ���Ʒ���
        /// </summary>
        /// <param name="saveToDisk">�Ƿ����</param>
        bool Draw(bool saveToDisk = false);

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="saveToDisk">�Ƿ����</param>
        bool Delete(bool saveToDisk = false);

        /// <summary>
        /// �ƶ�����
        /// </summary>
        /// <param name="x">Xƫ����</param>
        /// <param name="y">Yƫ����</param>
        void Move(double x, double y);
        #endregion // ����

        #region ����
        ///// <summary>
        ///// �ɼ�
        ///// </summary>
        //[Browsable(false)]
        //bool Visible { get; set; }
        /// <summary>
        /// ���ƶ����Ƿ�ѡ��
        /// </summary>
        [Browsable(false)]
        bool Selected { get; set; }

        /// <summary>
        /// ���ƶ����Ӧ��Ԫ������
        /// </summary>
        IElement ElementObj { get; set; }
        
        // TODO: Code Analysis Start(������ 2012/11/7 11:44:49) ����: [Υ����չԭ��] ���س̶�: [ 2  ]
        // ��ϸ˵��:  
        // DrawObject�Ƿ��о�������ͣ������о��������⻹������cad���һ�����͡�
        // 1��DrawObject�ɶ���ͼԪ��ɵ�������������1��ͼ��ƽ̨����2������ͼԪ���ϣ�ÿ��ͼԪ�ж�Ӧ������   
        // ======================================================= 
        //  ����		   �޸���	    	���� 

        /// <summary>
        /// ���ƶ�������
        /// </summary>
        DrawObjectType DrawObjType { get; }
        // Code Analysis End(������ 2012/11/7 11:44:53)

        /// <summary>
        /// ���ƶ�����������
        /// </summary>
        int HandleCount { get; set; }

        /// <summary>
        /// ͼԪ��Ϣ����
        /// </summary>
        List<FeatureLite> FeatureLists
        {
            get;
        }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

