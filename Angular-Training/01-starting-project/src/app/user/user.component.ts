import { Component, computed, Input, signal, input } from '@angular/core';
// importing DUMMY USERS array
import { DUMMY_USERS } from '../dummy-users';

const randomIndex =  Math.floor(Math.random() * DUMMY_USERS.length);

@Component({
  selector: 'app-user',
  standalone: true,
  imports: [],
  templateUrl: './user.component.html',
  styleUrl: './user.component.css'
})
export class UserComponent {
  avatar = input.required<string>();
  name = input.required<string>();
  imagePath = computed(() => 'assets/users/' + this.avatar());

  // get imagePath() {
  //   return 'assets/users/' + this.avatar();
  // }

  onSelectUser() {
  }
}
