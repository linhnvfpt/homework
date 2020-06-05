import { Component, OnInit } from '@angular/core';
import {
  MatDialog,
  MatDialogRef,
  MAT_DIALOG_DATA,
} from '@angular/material/dialog';
import { ChoosenComponentComponent } from './choosen-component/choosen-component.component';
import { data } from './data_state_checkbox';

export interface Element {
  mainsize: number;
}

const BRANCH_PIPE_DATA: Element[] = [
  { mainsize: 48 },
  { mainsize: 46 },
  { mainsize: 44 },
  { mainsize: 42 },
  { mainsize: 40 },
  { mainsize: 38 },
  { mainsize: 36 },
  { mainsize: 34 },
  { mainsize: 32 },
  { mainsize: 30 },
  { mainsize: 28 },
  { mainsize: 26 },
  { mainsize: 24 },
  { mainsize: 22 },
  { mainsize: 20 },
  { mainsize: 18 },
  { mainsize: 16 },
  { mainsize: 14 },
  { mainsize: 12 },
  { mainsize: 10 },
  { mainsize: 8 },
  { mainsize: 6 },
  { mainsize: 5 },
  { mainsize: 4 },
  { mainsize: 3.5 },
  { mainsize: 3 },
  { mainsize: 2.5 },
  { mainsize: 2 },
  { mainsize: 1.5 },
  { mainsize: 1.25 },
  { mainsize: 1 },
  { mainsize: 0.75 },
  { mainsize: 0.5 },
  { mainsize: 0.375 },
  { mainsize: 0.25 },
  { mainsize: 0.125 },
];

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  cell_content: string = 'R,O,C,S';
  isMouseDown: boolean = false;
  data = data[0];

  displayedColumns: string[] = [
    'Inch',
    '0.125',
    '0.25',
    '0.375',
    '0.5',
    '0.75',
    '1',
    '1.25',
    '1.5',
    '2',
    '2.5',
    '3',
    '3.5',
    '4',
    '5',
    '6',
    '8',
    '10',
    '12',
    '14',
    '16',
    '18',
    '20',
    '22',
    '24',
    '26',
    '28',
    '30',
    '32',
    '34',
    '36',
    '38',
    '40',
    '42',
    '44',
    '46',
    '48',
  ];
  dataSource = BRANCH_PIPE_DATA;

  constructor(public dialog: MatDialog) {}

  ngOnInit() {}

  onClickCell(event: Event) {
    // Remove id #cellSelected
    let foundEl = document.querySelector('#cellSelected');
    if (foundEl != null) {
      foundEl.removeAttribute('id');
    }

    // Get item that click and add class highlighted for it
    let mouseEvent: MouseEvent = event as MouseEvent;
    let element: HTMLTableCellElement = mouseEvent.srcElement as HTMLTableCellElement;
    element.id = 'cellSelected';
    if (element.classList.contains('highlighted') == false)
      element.classList.add('highlighted');

    // When user select multi cell, select cell
    let count_R:number = 0;
    let count_O:number = 0;
    let count_C:number = 0;
    let count_S:number = 0;

    //
    let els_highlight = document.querySelectorAll('.highlighted');
    els_highlight.forEach.call(els_highlight, function (el) {
      let content:string = el.innerText;
      if (content.indexOf('R') > -1) count_R++;
      if (content.indexOf('O') > -1) count_O++;
      if (content.indexOf('C') > -1) count_C++;
      if (content.indexOf('S') > -1) count_S++;
    });

    if (count_R == 0) this.data.full_R = false;
    else if (count_R == els_highlight.length) this.data.full_R = true;
    else if (count_R < els_highlight.length)  this.data.undefine_R = true;

    if (count_O == 0) this.data.full_O = false;
    else if (count_O == els_highlight.length) this.data.full_O = true;
    else if (count_O < els_highlight.length)  this.data.undefine_O = true;

    if (count_C == 0) this.data.full_C = false;
    else if (count_C == els_highlight.length) this.data.full_C = true;
    else if (count_C < els_highlight.length)  this.data.undefine_C = true;

    if (count_S == 0) this.data.full_S = false;
    else if (count_S == els_highlight.length) this.data.full_S = true;
    else if (count_S < els_highlight.length)  this.data.undefine_S = true;
    console.log(this.data);
    // Open dialog with parameters
    const dialogRef = this.dialog.open(ChoosenComponentComponent, {
      width: '250px',
      height: '170px',
      data: { data: this.data },
    });

    // Process data after dialog closed
    dialogRef.afterClosed().subscribe((result) => {
      // Set text for cell with class "highlighted"
      // Remove class "highlighted" out of cell
      let els = document.querySelectorAll('.highlighted');
      els.forEach.call(els, function (el) {
        this.data = result;
        let content:string = el.innerHTML;
        if (this.data.full_R) {
          if (content.indexOf('R') == -1) content = 'R,' + content;
        }
        else {
          if (content.indexOf('R') > -1) content = content.replace('R','');
        }

        if (this.data.full_O) {
          if (content.indexOf('O') == -1) content = 'O,' + content;
        }
        else {
          if (content.indexOf('O') > -1) content = content.replace('O','');
        }

        if (this.data.full_C) {
          if (content.indexOf('C') == -1) content = 'C,' + content;
        }
        else {
          if (content.indexOf('C') > -1) content = content.replace('C','');
        }

        if (this.data.full_S) {
          if (content.indexOf('S') == -1) content = 'S,' + content;
        }
        else {
          if (content.indexOf('S') > -1) content = content.replace('S','');
        }

        el.innerHTML = content;
        el.classList.remove('highlighted');
      });
    });
    return false;
  }

  onMouseDown(event: MouseEvent) {
    if (event.button == 0) {
      // Click mouse left
      this.isMouseDown = !this.isMouseDown;
      let element: HTMLTableCellElement = event.srcElement as HTMLTableCellElement;
      if (element.tagName.toLowerCase() === 'td') {
        if (this.isMouseDown) element.classList.add('highlighted');
      }
    }
    return false;
  }

  onMouseOver(event: MouseEvent) {
    // if (event.button == 0) {
    //   let element: HTMLTableCellElement = event.srcElement as HTMLTableCellElement;
    //   if (element.tagName.toLowerCase() === 'td') {
    //     if (this.isMouseDown)
    //       element.setAttribute('style', 'background-color:#999');
    //     else element.setAttribute('style', 'background-color:white');
    //   }
    // }
    // return false;
  }

  onMouseUp(event: MouseEvent) {
    this.isMouseDown = false;
    return false;
  }
}
