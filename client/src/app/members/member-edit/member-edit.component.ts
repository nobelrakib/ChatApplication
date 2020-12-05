import { Component, HostListener, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { take } from 'rxjs/operators';
import { Member } from 'src/app/_model/Member';
import { User } from 'src/app/_model/user';
import { AccountService } from 'src/app/_services/account.service';
import { MembersService } from 'src/app/_services/members.service';

@Component({
  selector: 'app-member-edit',
  templateUrl: './member-edit.component.html',
  styleUrls: ['./member-edit.component.css']
})
export class MemberEditComponent implements OnInit {

  user : User;
  member : Member;
  @ViewChild('editForm') editForm : NgForm;
  
  @HostListener('window:beforeunload', ['$event']) unloadNotification($event: any) {
    if (this.editForm.dirty) {
      $event.returnValue = true;
    }
  }
  constructor(private accountService:AccountService, private memberService : MembersService,private toaster : ToastrService){ 
    this.accountService.currentUser$.pipe(take(1)).subscribe(user=>{
      this.user=user;
    });
  }


  ngOnInit(): void {
    this.loadMember();
  }

  loadMember(){
    this.memberService.getMember(this.user.username).subscribe(member=>{
         this.member=member;
    });
  }

  updateMember(){
    this.memberService.updateMember(this.member).subscribe(()=>{
       
      this.editForm.reset(this.member);
     this.toaster.success('sucessfullyUpdated');


    });
    

  }


}
