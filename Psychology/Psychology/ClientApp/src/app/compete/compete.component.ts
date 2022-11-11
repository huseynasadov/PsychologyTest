import { Component, Input, OnInit } from '@angular/core';
import { Answer } from '../shared/models/answer';

@Component({
  selector: 'app-compete',
  templateUrl: './compete.component.html',
  styleUrls: ['./compete.component.css']
})
export class CompeteComponent implements OnInit {

  @Input () public answers :   Answer[];
  introvert : number = 0;
  extrovert : number = 0;
  textIn: string = "You are more of a private introvert and public extrovert";
  textEx: string = "You are more of a public extrovert and private introvert";
  constructor() { }

  ngOnInit() {
    
    this.answers.forEach(f =>{
      this.introvert+=f.percentageIntrovert;
    });
    this.introvert = this.introvert / this.answers.length;
    this.extrovert = 100 - this.introvert;
    
  }

}
