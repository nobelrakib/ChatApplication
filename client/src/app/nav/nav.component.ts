import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model : any ={

  }
  
  constructor(public accountServce : AccountService,private router : Router,private toastr: ToastrService) { }

  ngOnInit(): void {
    
  }
  Login(){
    
    this.accountServce.login(this.model).subscribe(respose=>{
      this.router.navigateByUrl('/members');
      this.toastr.success('success');
    },error=>{
      // console.log(error);
       this.toastr.error(error)
    });
    
    
  }
  logout(){
    this.accountServce.logout();
    this.router.navigateByUrl('/')
  }

  

}
