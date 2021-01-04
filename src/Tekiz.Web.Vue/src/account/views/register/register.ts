import { Component } from "vue-property-decorator";
import TekizComponentBase from "@/shared/application/Tekiz-component-base";

@Component
export default class RegisterComponent extends TekizComponentBase {
  refs = this.$refs as any;
  registerInput = {} as IRegisterInput;
  errors: INameValueDto[] = [];
  resultMessage: string | undefined;
  registerComplete = false;

  onSubmit() {
    if (this.refs.form.validate()) {
      this.TekizService.post<IRegisterOutput>(
        "/api/register",
        this.registerInput
      ).then((response) => {
        if (!response.isError) {
          this.resultMessage = this.$t("AccountCreationSuccessful").toString();
          this.registerComplete = true;
        } else {
          this.errors = response.errors;
        }
      });
    }
  }
}
