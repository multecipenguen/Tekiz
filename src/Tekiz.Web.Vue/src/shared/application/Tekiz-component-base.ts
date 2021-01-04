﻿import Vue from "vue";
import TekizService from "@/shared/application/tekiz-service-proxy";
import QueryString from "query-string";
import Tekiz from "@/shared/application/tekiz";
import Swal from "sweetalert2";
import AuthStore from "@/stores/auth-store";
import { Component } from "vue-property-decorator";

@Component
export default class TekizComponentBase extends Vue {
  protected TekizService: TekizService = new TekizService();
  protected queryString = QueryString;
  protected Tekiz = Tekiz;
  protected authStore = AuthStore;
  protected requiredError = (v: any) => !!v || this.t("RequiredField");
  protected emailError = (v: any) =>
    /.+@.+/.test(v) || this.t("EmailValidationError");

  protected swalToast(duration: number, type: string, title: string) {
    Swal.fire({
      toast: true,
      position: "bottom-end",
      showConfirmButton: false,
      timer: duration,
      type,
      title,
    } as any);
  }

  protected swalConfirm(title: string) {
    return Swal.fire({
      title,
      type: "warning",
      showCancelButton: true,
      confirmButtonText: this.$t("Yes").toString(),
      cancelButtonText: this.$t("No").toString(),
    } as any);
  }

  protected swalAlert(type: string, html: string) {
    Swal.fire({
      html,
      type,
      showConfirmButton: false,
    } as any);
  }

  protected passwordMatchError(password: string, passwordRepeat: string) {
    return password == passwordRepeat
      ? ""
      : this.$t("PasswordsMustMatch").toString();
  }

  private t(key: string): string {
    return this.$t(key).toString();
  }
}
