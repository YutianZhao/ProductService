import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Users } from '../Models/Users/Users.Model';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private http: HttpClient) { }

  getUsersById(userId?: number): Observable<Users[]> {
    return this.http.get<Users[]>(`https://localhost:44363/api/users/${userId}`);
  }

  getUsers() {
    return this.http.get<Users[]>(`https://localhost:44363/api/users`);
  }
}
