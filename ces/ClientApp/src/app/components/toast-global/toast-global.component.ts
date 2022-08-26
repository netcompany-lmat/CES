import { Component, OnDestroy } from '@angular/core';

import { ToastService } from '../../services/toast/toast.service';

@Component({
  selector: 'ngbd-toast-global',
  templateUrl: './toast-global.component.html'
})
export class NgbdToastGlobal implements OnDestroy {
  constructor(public toastService: ToastService) {}

  showStandard(msg: string) {
    this.toastService.show(msg);
  }

  ngOnDestroy(): void {
    this.toastService.clear();
  }
}
