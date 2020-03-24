import { Component, OnInit } from '@angular/core';
import { UsersService } from 'src/app/Services/users.service';
import { Users } from 'src/app/Models/Users/Users.Model';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  userId: number;
  userList = new Array<Users>();

  constructor(private usersService: UsersService) { }

  ngOnInit() {
    this.getUsers();
  }

  getUsersById(id: number): void {
    id = this.userId;
    this.usersService.getUsersById(id).subscribe(res => this.userList = res);
  }

  getUsers(): void {
    this.usersService.getUsers().subscribe(res => this.userList = res);
  }
}
