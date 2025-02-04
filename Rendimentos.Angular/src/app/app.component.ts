import { Component, inject, signal } from "@angular/core";
import { FormBuilder, ReactiveFormsModule, Validators } from "@angular/forms";
import { NgxMaskDirective, NgxMaskPipe } from "ngx-mask";
import { AppService, RendimentoResponse } from "./app.service";

@Component({
  selector: "app-root",
  imports: [ReactiveFormsModule, NgxMaskDirective, NgxMaskPipe],
  templateUrl: "./app.component.html",
  styleUrl: "./app.component.css",
})
export class AppComponent {
  formBuilder = inject(FormBuilder);
  service = inject(AppService);

  rendimento = signal<RendimentoResponse | undefined>(undefined);

  form = this.formBuilder.group({
    valor: this.formBuilder.nonNullable.control<number>(0, [
      Validators.required,
      Validators.min(0.01),
    ]),
    meses: this.formBuilder.nonNullable.control<number>(0, [
      Validators.required,
      Validators.min(0),
    ]),
  });

  calcular() {
    if (this.form.invalid) {
      return;
    }

    this.service.calcular$(this.form.getRawValue()).subscribe({
      next: (value) => this.rendimento.set(value),
      error: (err: any) => {
      },
    });
  }
}
