import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-marriage-certificate-view',
  templateUrl: './marriage-certificate-view.component.html'
})
export class MarriageCertificateViewComponent implements OnInit {
  requestId: string;

  constructor(private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.requestId = this.activatedRoute.snapshot.params['id'];
  }
}
