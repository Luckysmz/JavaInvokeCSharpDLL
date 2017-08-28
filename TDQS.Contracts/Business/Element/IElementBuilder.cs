#region CLR�汾 4.0.30319.239
// IElementBuilder �ӿ�
// ʱ�䣺2012-2-28 11:05:23
// ���ƣ�IElementBuilder
// ��٣�Ԫ�������ӿ�
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
    /// Ԫ��������
    /// </summary>
    public interface IElementBuilder
    {
        #region ����

        /// <summary>
        /// ����һ��Ԫ��
        /// </summary>
        /// <param name="tempID">Ԫ��ģ��ID</param>
        /// <returns></returns>
        IElement CreateElement(string tempID);

        /// <summary>
        /// ����һ��Ԫ�� 
        /// </summary>
        /// <param name="elementType">Ԫ������</param>
        /// <param name="dataBase">���ݿ����</param>
        /// <returns>������Ԫ��</returns>
        IElement CreateElement(ElementType elementType, IDatabase dataBase);

        /// <summary>
        /// ����һ��Ԫ�� 
        /// </summary>
        /// <param name="elementType">Ԫ������</param>
        /// <returns>������Ԫ��</returns>
        IElement CreateElement(ElementType elementType);

        /// <summary>
        /// ����һ��Ԫ����һ���µ�Ԫ������(֧�ֿ�ͼ����)
        /// </summary>
        /// <param name="sourceObj">ԴԪ������</param>
        /// <param name="bool">�Ƿ�ı�����</param>
        /// <param name="bool">�Ƿ�������ƶ���</param>
        /// <returns>Ŀ����Ԫ������</returns>
        IElement CopyElement(IElement sourceObj,ICanvasView canvasView, bool bChangeName = false, bool bHasDrawObj = true, bool bSynSave = true, bool bCopyToTemplate = false);


        /// <summary>
        /// ����һ��Ԫ����һ���µ�Ԫ������(�ǿ�ͼ����)
        /// </summary>
        /// <param name="sourceObj">ԴԪ������</param>
        /// <param name="bool">�Ƿ�ı�����</param>
        /// <param name="bool">�Ƿ�������ƶ���</param>
        /// <returns>Ŀ����Ԫ������</returns>
        IElement CopyElement(IElement sourceObj, bool bChangeName = false, bool bHasDrawObj = true, bool bSynSave = true, bool bCopyToTemplate = false);


        /// <summary>
        /// ͨ��Ԫ�����ͻ��Ԫ����ʼ����
        /// </summary>
        /// <param name="etype"></param>
        /// <returns></returns>
        String ElementTypeToTypeName(ElementType etype);

        /// <summary>
        /// Ԫ�����ͻ�ñ���
        /// </summary>
        /// <param name="etype">Ԫ������</param>
        /// <returns>����</returns>
        String ElementTypeToTableName(ElementType etype);

        #endregion // ����

        #region ����

        /// <summary>
        /// ��ǰ��ͼ
        /// </summary>
        ICanvasView CanvasView
        { 
            get;
            set; 
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

