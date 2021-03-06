//  
//  Person.cs
//  
//  Author:
//       Craig Fowler <craig@craigfowler.me.uk>
// 
//  Copyright (c) 2012 CSF Software Limited
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using CSF.Patterns.DDD.Entities;

namespace CSF.Patterns.DDD.Mocks.Entities
{
  public class Person : Entity<uint>
  {
    #region fields
    
    private string _name, _telephoneNumber;
    
    #endregion
    
    #region properties
    
    public string Name
    {
      get {
        return _name;
      }
      set {
        _name = value;
        this.OnDirty();
      }
    }
    
    public string TelephoneNumber
    {
      get {
        return _telephoneNumber;
      }
      set {
        _telephoneNumber = value;
        this.OnDirty();
      }
    }
    
    #endregion
    
    #region constructors
    
    public Person () : base() {}
    
    public Person (uint id) : base(id) {}
    
    #endregion
  }
}

