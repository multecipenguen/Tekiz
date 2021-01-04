import { Component } from "vue-property-decorator";
import TekizComponentBase from "@/shared/application/Tekiz-component-base";

@Component
export default class ForgotPasswordComponent extends TekizComponentBase {
  refs = this.$refs as any;
  forgotPasswordInput = {} as IForgotPasswordInput;
  errors: INameValueDto[] = [];
  isEmailSent = false;
  resultMessage: string | undefined;

  onSubmit() {
    if (this.refs.form.validate()) {
      this.TekizService.post<IForgotPasswordOutput>(
        "/api/forgotPassword",
        this.forgotPasswordInput
      ).then((response) => {
        if (!response.isError) {
          this.resultMessage = this.$t("EMailSentSuccessfully").toString();
          this.isEmailSent = true;
        } else {
          this.errors = response.errors;
        }
      });
    }
  }
}
