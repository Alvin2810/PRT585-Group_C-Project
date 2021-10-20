import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';

@Component({
  selector: 'app-input-markdown',
  templateUrl: './input-markdown.component.html',
  styleUrls: ['./input-markdown.component.scss']
})
export class InputMarkdownComponent implements OnInit {

  constructor() {}

  @Output()
  changeMarkdown= new EventEmitter<string>();

  @Input()
  markdownContent:any;

  ngOnInit(): void {
  }

}
