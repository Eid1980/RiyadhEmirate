import { Component, OnInit } from '@angular/core';
import { MessageType } from '@shared/enums/message-type.enum';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-list-poster',
  templateUrl: './list-poster.component.html'
})
export class ListPosterComponent implements OnInit {
  posters:any[]=[];
  id:number;

  constructor(private fileManagerService: FileManagerService, private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.getAll();
  }
  getAll(){
    this.fileManagerService.getByEntityName('Poster').subscribe((res:any[]) =>{
     this.posters = res;
    });
  }  
  onRemove(id: string) {
    this.globalService.showConfirm('هل تريد حذف هذا الإعلان؟');
    this.globalService.confirmSubmit = () => this.isconfirm(id);
  }
  isconfirm(id: string) {
    this.fileManagerService.delete(id).subscribe(res => {
      this.getAll();
      this.globalService.messageAlert(MessageType.Success, 'تم حذف الإعلان');
    });
  }

  changeStatus(id,event){
    this.fileManagerService.changeStatus(id).subscribe(res=>{
      this.getAll();
      this.globalService.messageAlert(MessageType.Success,'تم تغيير الحالة');
     })
  }

}
