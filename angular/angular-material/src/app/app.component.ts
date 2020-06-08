import { Component, OnInit,  AfterViewInit } from '@angular/core';
import {
  MatDialog,
  MatDialogRef,
  MAT_DIALOG_DATA,
} from '@angular/material/dialog';
import { ChoosenComponentComponent } from './choosen-component/choosen-component.component';
import { data, data_state_checkbox } from './data_state_checkbox';
import { RouterLinkWithHref } from '@angular/router';

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
export class AppComponent implements OnInit, AfterViewInit {
  cell_content: string = 'R,O,C,S';
  is_highlighted: boolean = false;
  data = data[0];
  temp: data_state_checkbox;
  cell_index_old:number = 1;

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

  ngOnInit() {
    
  }

  ngAfterViewInit() {
    let table = document.getElementById("branch_table") as HTMLTableElement;
    // Add color for column index 0
    for (let i = 0; i < table.rows.length; i++) {
      table.rows[i].cells.item(0).classList.add('cell_index_0');
    }

    for (let i = 1; i < table.rows.length; i++) {
      let cells = table.rows[i].cells;
      let cell_remove = i - 1;
      let len_cells = cells.length - 1;
      for (let j = len_cells; j > len_cells - cell_remove; j --) {
        cells.item(j).style.display = 'none';
      }
      cells.item(len_cells - cell_remove).innerText = 'T,S';
    }
  }

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
    let count_R: number = 0;
    let count_O: number = 0;
    let count_C: number = 0;
    let count_S: number = 0;
    let count_T: number = 0;

    //
    let els_highlight = document.querySelectorAll('.highlighted');
    els_highlight.forEach.call(els_highlight, function (el) {
      let content: string = el.innerText;
      if (content.indexOf('R') > -1) count_R++;
      if (content.indexOf('O') > -1) count_O++;
      if (content.indexOf('C') > -1) count_C++;
      if (content.indexOf('S') > -1) count_S++;
      if (content.indexOf('TR') > -1) count_T++;
    });

    if (count_R == 0) this.data.full_R = false;
    else if (count_R == els_highlight.length) {
      this.data.full_R = true;
      this.data.undefine_R = false;
    } else if (count_R < els_highlight.length) {
      this.data.undefine_R = true;
    }

    if (count_O == 0) this.data.full_O = false;
    else if (count_O == els_highlight.length) {
      this.data.full_O = true;
      this.data.undefine_O = false;
    } else if (count_O < els_highlight.length) {
      this.data.undefine_O = true;
    }

    if (count_C == 0) this.data.full_C = false;
    else if (count_C == els_highlight.length) {
      this.data.full_C = true;
      this.data.undefine_C = false;
    } else if (count_C < els_highlight.length) {
      this.data.undefine_C = true;
    }

    if (count_S == 0) this.data.full_S = false;
    else if (count_S == els_highlight.length) {
      this.data.full_S = true;
      this.data.undefine_S = false;
    } else if (count_S < els_highlight.length) {
      this.data.undefine_S = true;
    }

    if (count_T == 0) this.data.full_T = false;
    else if (count_T == els_highlight.length) {
      this.data.full_T = true;
      this.data.undefine_T = false;
    } else if (count_T < els_highlight.length) {
      this.data.undefine_T = true;
    }

    // Open dialog with parameters
    const dialogRef = this.dialog.open(ChoosenComponentComponent, {
      width: '350px',
      height: '190px',
      data: this.data,
    });

    // Process data after dialog closed
    dialogRef.afterClosed().subscribe((result) => {
      // Set text for cell with class "highlighted"
      // Remove class "highlighted" out of cell
      let els = document.querySelectorAll('.highlighted');
      els.forEach.call(els, function (el) {
        let content: string = el.innerText;
        if (result.full_R) {
          if (content.indexOf('R') == -1) content = 'R,' + content;
        } else {
          // if checkbox R has status empty, no full, no indeterminate and content has 'R' => replace 'R'
          if (content.indexOf('R') > -1 && result.undefine_R == false)
            content = content.replace('R,', '');
        }

        if (result.full_O) {
          if (content.indexOf('O') == -1) content = 'O,' + content;
        } else {
          // if checkbox O has status empty, no full, no indeterminate and content has 'O' => replace 'O'
          if (content.indexOf('O') > -1 && result.undefine_O == false)
            content = content.replace('O,', '');
        }

        if (result.full_C) {
          if (content.indexOf('C') == -1) content = 'C,' + content;
        } else {
          // if checkbox C has status empty, no full, no indeterminate and content has 'C' => replace 'C'
          if (content.indexOf('C') > -1 && result.undefine_C == false)
            content = content.replace('C,', '');
        }

        if (result.full_S) {
          if (content.indexOf('S') == -1) content = 'S,' + content;
        } else {
          // if checkbox S has status empty, no full, no indeterminate and content has 'S' => replace 'S'
          if (content.indexOf('S') > -1 && result.undefine_S == false)
            content = content.replace('S', '');
        }

        if (result.full_T) {
          if (content.indexOf('TR') == -1) content = 'TR,' + content;
        } else {
          // if checkbox T has status empty, no full, no indeterminate and content has 'T' => replace 'T'
          if (content.indexOf('TR') > -1 && result.undefine_S == false)
            content = content.replace('TR,', '');
        }
       
        let temp:string = '';
        if (content.indexOf('R') > -1) temp += 'R,';
        if (content.indexOf('O') > -1) temp += 'O,';
        if (content.indexOf('C') > -1) temp += 'C,';
        if (content.indexOf('S') > -1) temp += 'S,';
        if (content.indexOf('TR') > -1) temp += 'TR,';
        if (temp.charAt(temp.length - 1) == ',')
          temp = temp.slice(0,temp.length - 1);
        el.innerText = temp;
        el.classList.remove('highlighted');
      });
    });
    return false;
  }

  onMouseDown(event: MouseEvent) {
    if (event.button == 0) {
      // Click mouse left
      // Get element that raised event mouse left
      let element: HTMLTableCellElement = event.srcElement as HTMLTableCellElement;
      if (event.ctrlKey) {
        // have ctrl key - multi select
        if (element.tagName.toLowerCase() === 'td') {
          element.classList.add('highlighted');
        }
      } 
      else 
      {
        //  no ctrl key
        let els = document.querySelectorAll('.highlighted');
        if (els.length == 0) {
          //  if no element highlight then set highlight for that element, 
          if (element.tagName.toLowerCase() === 'td') { 
            element.classList.add('highlighted'); 
            this.is_highlighted = true; 
            this.cell_index_old = element.cellIndex;
          }
        } 
        else 
        {
          //  if some element highlighted then remove highlight for all element, then set highlight for current element
          // remove all elements highlighted
          els.forEach.call(els, function (el) {
            if (el.tagName.toLowerCase() === 'td') {       
              el.classList.remove('highlighted');
            }
          });

          // set highlight for current element
          // this.is_highlighted = !this.is_highlighted;
          if (this.cell_index_old != element.cellIndex) element.classList.add('highlighted');
          this.cell_index_old = element.cellIndex;
        }
      }
    }
    return false;
  }

  onMouseOver(event: MouseEvent) {
    // if (event.button == 0) {
    //   let element: HTMLTableCellElement = event.srcElement as HTMLTableCellElement;
    //   if (element.tagName.toLowerCase() === 'td') {
    //     element.classList.add('highlighted');
    //   }
    // }
    // return false;
  }

  onMouseUp(event: MouseEvent) {
    //this.isMouseDown = false;
    return false;
  }
}
