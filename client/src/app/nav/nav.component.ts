import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model : any ={

  }
  
  constructor(public accountServce : AccountService) { }

  ngOnInit(): void {
    
  }
  Login(){
    
    this.accountServce.login(this.model).subscribe(respose=>{
      console.log("ki"+respose);
      
    },error=>{
       console.log(error);
    });
    
    
  }
  logout(){
    this.accountServce.logout();
    
  }

  

}
