#region CLR�汾 4.0.30319.239
// IElementCollection �ӿ�
// ʱ�䣺2011-11-18 16:53:16
// ���ƣ�IElementCollection
// ��٣�����Ԫ�����ϣ�����ԭCNP4.0ϵͳ ��
//
// �����ˣ����� (ԭCNP4.0������wss)
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TDQS.Contracts
{
    /// <summary>
    /// ����Ԫ�����Ͻӿڣ�������Notifyģʽ)
    /// </summary>
    public interface IElementCollection : IEnumerable<IElement>
    {
        #region ����

        #region ��ȡ
        /// <summary>
        /// ��ǰ����Դ���Ƿ����ĳԪ��
        /// </summary>
        /// <param name="element">Ԫ��</param>
        /// <returns></returns>
        bool Contains(IElement element);

        /// <summary>
        /// ��ǰ����Դ���Ƿ���Ȱ���ĳԪ�� (��������Ԫ���е��Ӽ�)
        /// </summary>
        /// <param name="element">Ԫ��</param>
        /// <returns></returns>
        bool DeepContains(IElement element);

        /// <summary>
        /// ��ȡĳԪ��
        /// </summary>
        /// <param name="id">Ԫ��ID</param>
        /// <returns>Ԫ��</returns>
        IElement Get(string id);

        /// <summary>
        /// ��ȡԪ������
        /// </summary>
        /// <param name="sID"></param>
        /// <returns></returns>
        ICollection<IElement> Get(ICollection<string> sID);

        /// <summary>
        /// ��ȡ����Ԫ������
        /// </summary>
        /// <param name="sID"></param>
        /// <returns></returns>
        ICollection<IElement> Get();

        /// <summary>
        /// ��ȡ��ǰ������������Ԫ������
        /// </summary>
        /// <returns></returns>
        ICollection<ElementType> GetDistincateElementType();

        /// <summary>
        /// ��ȡĳ����Ԫ������
        /// </summary>
        /// <typeparam name="elementType">Ԫ������</typeparam>
        /// <returns></returns>
        ICollection<ElementType> Get<ElementType>()
            where ElementType : IElement;//, new();// �����޸� 2013-9-22��ȥ�����Ͳ���new()�s��

        /// <summary>
        /// ��ȡĳ����Ԫ������
        /// </summary>
        /// <typeparam name="elementType">Ԫ������</typeparam>
        /// <returns>Ԫ������</returns>
        ICollection<IElement> Get(ElementType elementType);
        #endregion

        #region Count

        /// <summary>
        /// ����Ԫ������
        /// </summary>
        int Count();

        /// <summary>
        /// ����ĳ����Ԫ���ĸ���
        /// </summary>
        /// <typeparam name="elementType">Ԫ������</typeparam>
        /// <returns>Ԫ������</returns>
        int Count<ElementType>()
            where ElementType : IElement, new();

        #endregion

        #region Add

        /// <summary>
        /// ���һ��Ԫ��������Դ
        /// </summary>
        /// <param name="element">Ԫ��</param>
        bool Add(IElement element);

        /// <summary>
        /// ���һ��Ԫ��
        /// </summary>
        /// <param name="elements">Ԫ������</param>
        /// <returns>�����Ƿ�ɹ�</returns>
        bool Add(ICollection<IElement> elements);
        #endregion // Add

        #region Remove
        /// <summary>
        /// ɾ��Ԫ��
        /// </summary>
        /// <param name="element">Ԫ��</param>
        bool Remove(IElement element);

        /// <summary>
        /// ɾ��Ԫ��
        /// </summary>
        /// <param name="element">Ԫ��</param>
        bool Remove(string id);

        /// <summary>
        /// ɾ��Ԫ��
        /// </summary>
        /// <param name="element">Ԫ��</param>
        bool Remove(ICollection<IElement> elements);

        /// <summary>
        /// ɾ��Ԫ��
        /// </summary>
        /// <param name="element">Ԫ��</param>
        bool Remove(ICollection<string> IDs);
        #endregion


        #endregion // ����

        #region ����

        #region �����Ż� ������, 2013/3/26 16:51:08, �޸ģ�ɾ���Ż� ɾ��Ԫ�����ݱ��˵����
       
        #endregion �����Ż�
        /// <summary>
        /// ���û�����
        /// </summary>
        IDictionary<string, IElement> ElementCache
        {
            get;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

