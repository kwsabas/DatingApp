using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    /* An interface is kind of a contract between itself and any class that implements it.
    This contract states that any class that implements this interface will implement
    the interfaces properties, the methods and or events.
    An interface does not contain any implementation logic, and it only contains the signatures
    of the functionality the interface provides.
    */
    public interface ITokenService
    {
        string Createtoken(AppUser user);
    }
}