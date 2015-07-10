//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : OSite
//  @ File Name : ImemberDAL.cs
//  @ Date : 2011/8/23
//  @ Author : 
//
//

using System;
using System.Data;
using J6.DevFw.Data;

namespace J6.Cms.IDAL
{
    public interface ImemberDAL
    {
        bool DetectUserName(string username);
        bool DetectNickName(string nickrname);
        bool DetectUserAndNickNameExist(string username, string nickname);
        void RegisterMember(string username, string password, string avatar, string sex, string nickname, string note, string email, string telephone);
        void Update(int memberId, string password, string nickname, string avatar, string sex, string email, string telephone, string note);
        void InsertDetails(int memberID, string status, string regIP, string token);
        int GetMemberUid(string username);
        void VerifyMember(string username, string password, DataReaderFunc func);
        void GetMemberByID(int id, DataReaderFunc func);
        void GetMemberByUsername(string username, DataReaderFunc func);
        void GetMemberDetailsByUsername(string username, DataReaderFunc func);
        void GetMemberDetailsByID(int id, DataReaderFunc func);
        void Delete(int memberID);
        DataTable GetPagedMembers(int pageSize, ref int currentPageIndex, out int recordCount, out int pageCount, DateTime? time);
    }
}