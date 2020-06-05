import { Component, OnInit } from '@angular/core';
import {
  MatDialog,
  MatDialogRef,
  MAT_DIALOG_DATA,
} from '@angular/material/dialog';
import { ChoosenComponentComponent } from './choosen-component/choosen-component.component';

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

interface Comp {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'angular material';
  cell_content: string = 'R,O,C,S';
  isMouseDown: boolean = false;
  isHighlighted: boolean;
  array_cell_content:string[];

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
    let foundEl = document.querySelector('#cellSelected');
    if (foundEl != null) {
      foundEl.removeAttribute('id');
    }

    let mouseEvent: MouseEvent = event as MouseEvent;
    let element: HTMLTableCellElement = mouseEvent.srcElement as HTMLTableCellElement;
    element.id = 'cellSelected';
    if (element.classList.contains('highlighted') == false)
      element.classList.add('highlighted');

    // When user select multi cell, select cell
    let isHasR = false;
    let isHasO = false;
    let isHasC = false;
    let isHasS = false;
    let isFull = false;

    let els_highlight = document.querySelectorAll('.highlighted');
    els_highlight.forEach.call(els_highlight, function (el) {
      let content:string = el.innerText;
      if (content.indexOf('R') > -1) {
        isHasR = true;
      }
      else isHasR = false;

      if (content.indexOf('O') > -1) {
        isHasO = true;
      } 
      else isHasO = false;

      if (content.indexOf('C') > -1) {
        isHasC = true;
      }
      else isHasC = false;

      if (content.indexOf('S') > -1) {
        isHasS = true;
      }
      else isHasS = false;
    });

    if (isHasR && isHasO && isHasC && isHasS) isFull = true;

    // // Miss 1 component
    // if (isHasR && isHasO && isHasC && !isHasS) isMissS = true;
    // if (isHasR && isHasO && !isHasC && isHasS) isMissC = true;
    // if (isHasR && !isHasO && isHasC && isHasS) isMissO = true;
    // if (!isHasR && isHasO && isHasC && isHasS) isMissR = true;

    // // Miss 2 component
    // if (isHasR && isHasO && !isHasC && !isHasS) isMissCS = true;
    // if (isHasR && !isHasO && !isHasC && isHasS) isMissOC = true;
    // if (!isHasR && !isHasO && isHasC && isHasS) isMissRO = true;
    // if (!isHasR && isHasO && isHasC && isHasS) isMissR = true;

    // // Miss 3 component
    // if (isHasR && isHasO && isHasC && !isHasS) isMissS = true;
    // if (isHasR && isHasO && !isHasC && isHasS) isMissC = true;
    // if (isHasR && !isHasO && isHasC && isHasS) isMissO = true;
    // if (!isHasR && isHasO && isHasC && isHasS) isMissR = true;


    const dialogRef = this.dialog.open(ChoosenComponentComponent, {
      width: '250px',
      height: '170px',
      data: { cell_content: element.innerText },
    });

    dialogRef.afterClosed().subscribe((result) => {
      // Set text for cell with class "highlighted"
      // Remove class "highlighted" out of cell
      let els = document.querySelectorAll('.highlighted');
      els.forEach.call(els, function (el) {
        el.innerHTML = result;
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
