@Code
    Layout = "~/Views/_Main.vbhtml"
    PageData("Title") = "Modals Test"
End Code

<div class="row">
    <div class="col-lg-12">
        <h1 class="page-header">@PageData("Title")</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>
<!-- /.row -->

<div class="row">
    <div class="col-lg-12">
        <div class="panel panel-default">
            <div class="panel-heading">
                Modal Inputs fields calculate totals
            </div>
            <!-- /.panel-heading -->
            <div class="panel-body">
                <!-- Button trigger modal -->
                <button class="btn btn-primary btn-xs" onclick="remittanceOptions(); return false;">
                    Generate Remittance
                </button>

                <button class="btn btn-success btn-xs"  data-toggle="modal" data-target="#consolidatedTransactions">
                    Consolidated Reconciling Transactions
                </button>

                <button class="btn btn-warning btn-xs" data-toggle="modal" data-target="#storeSpecificTransactions">
                    Store Specific Reconciling Transactions
                </button>
                
                <!-- REMITTANCE OPTIONS Modal -->
                <div class="modal fade" id="remittanceOptions" tabindex="-1" role="dialog">
                    <div class="modal-dialog modal-sm" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h5 class="modal-title text-primary">Reconcile your payment</h5>
                            </div>
                            <div class="modal-body">
                                <div class="alert alert-info" role="alert">
                                    <div class="media">
                                        <div class="media-left" style="padding-left:2px">
                                            <i class="fa fa-question-circle fa-3x"></i>
                                        </div>
                                        <div class="media-body">
                                            Do you wish to reconcile your selected payment balance of <b>R<span class="ReconTotal">620.12</span></b> to the suppliers statement?
                                        </div>
                                    </div>
                                </div>
                                <div id="reconcilePayment" style="display: none;">
                                    <p>Please select your statement option:</p>
                                    <a href="#" class="btn btn-default btn-sm statementOption" data-toggle="modal" data-target="#consolidatedGenerate" data-dismiss="modal">Consolidated</a>
                                    <a href="#" class="btn btn-default btn-sm statementOption" data-toggle="modal" data-target="#storeSpecificGenerate" data-dismiss="modal">Store Specific</a>
                                    <!--<a href="#" class="btn btn-default btn-sm" data-toggle="modal" data-target="#consolidatedGenerate" data-dismiss="modal">Consolidated</a>
                        <a href="#" class="btn btn-default btn-sm" data-toggle="modal" data-target="#storeSpecificGenerate" data-dismiss="modal">Store Specific</a>-->
                                </div>
                            </div>
                            <div class="modal-footer">
                                <Input type="button" value="NO" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#generateRebate" data-dismiss="modal">
                                <Input type="button" value="YES" class="btn btn-primary btn-sm" onclick="reconcilePayment(); return false;">
                            </div>
                        </div>
                    </div>
                </div>

                <!-- GENERATE REBATE Modal -->
                <div class="modal fade" id="generateRebate" tabindex="-1" role="dialog">
                    <div class="modal-dialog modal-sm" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h5 class="modal-title text-warning">Generate Rebate</h5>
                            </div>
                            <div class="modal-body">
                                <div class="alert alert-warning" role="alert">
                                    <div class="media">
                                        <div class="media-left" style="padding-left:2px">
                                            <i class="fa fa-exclamation-circle fa-3x"></i>
                                        </div>
                                        <div class="media-body">
                                            <p>Are you sure you wish to generate the rebate for the selected transactions? The selected transactions is:</p>
                                            <h5><b>R<span class="ReconTotal">620.12</span></b></h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <Input type="button" value="Cancel" class="btn btn-primary btn-sm" data-dismiss="modal">
                                <Input type="button" value="Generate Rebate" onclick="doRebateNew(); return false;" class="btn btn-primary btn-sm" data-dismiss="modal">
                            </div>
                        </div>
                    </div>
                </div>

                <!------------------------------ CONSOLIDATED MODALS ------------------------------>
                <!-- CONSOLIDATED GENERATE Modal -->
                <div class="modal fade" id="consolidatedGenerate" tabindex="-1" role="dialog">
                    <div class="modal-dialog modal-sm" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h5 class="modal-title">Generate Consolidated Remittance</h5>
                            </div>
                            <div class="modal-body">
                                <p>Your are about to generate the Consolidated Remittance Recon for the selected transactions? The selected transactions is:</p>
                                <h5><b>R<span class="ReconTotal">620.12</span></b></h5>
                                <p>Please enter your statement balance for <b>_Test Creditor</b> as at <b>21-Nov-2017</b>:</p>
                                <div class="clearfix">
                                    <input type="text" class="form-control input-sm" id="" placeholder="0.00" value="0.00">
                                </div>
                            </div>
                            <div class="modal-footer">
                                <Input type="button" value="Submit Amount" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#consolidatedVariance" data-dismiss="modal">
                            </div>
                        </div>
                    </div>
                </div>

                <!-- CONSOLIDATED VARIANCE Modal -->
                <div class="modal fade" id="consolidatedVariance" tabindex="-1" role="dialog">
                    <div class="modal-dialog modal-sm" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h5 class="modal-title text-warning">Consolidated Remittance Variance</h5>
                            </div>
                            <div class="modal-body">
                                <div class="alert alert-warning" role="alert">
                                    <div class="media">
                                        <div class="media-left" style="padding-left:2px">
                                            <i class="fa fa-exclamation-circle fa-3x"></i>
                                        </div>
                                        <div class="media-body">
                                            <b>Please Note:</b> There is a variance of <b>615.06</b> between your remittance and the supplier statement, do you wisth to continue?
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <Input type="button" value="Back" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#consolidatedGenerate" data-dismiss="modal">
                                <Input type="button" value="NO" class="btn btn-primary btn-sm" data-dismiss="modal">
                                <Input type="button" value="YES" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#consolidatedTransactions" data-dismiss="modal">
                            </div>
                        </div>
                    </div>
                </div>

                <!-- CONSOLIDATED TRANSACTIONS Modal -->
                <div class="modal fade" id="consolidatedTransactions" tabindex="-1" role="dialog">
                    <div class="modal-dialog modal-md" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h5 class="modal-title">Reconciling Transactions</h5>
                            </div>
                            <div class="modal-body">
                                <p>Please enter the reconciling transactions:</p>
                                <table class="table table-striped table-bordered table-condensed" id="reconTransAction">
                                    <thead>
                                        <tr>
                                            <th>Date</th>
                                            <th>Invoice Number</th>
                                            <th>Note</th>
                                            <th class="text-right">Amount</th>
                                            <th>&nbsp;</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <div class="input-group date smallfield pull-left">
                                                    <input type="text" class="form-control datepicker" placeholder="Transaction Date" value="17-Sept-2017">
                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                </div>
                                            </td>
                                            <td>
                                                <input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="1234">
                                            </td>
                                            <td>
                                                <input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="Invalid Invoice">
                                            </td>
                                            <td>
                                                <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="500.00">
                                            </td>
                                            <td class="text-center">
                                                <button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="input-group date smallfield pull-left">
                                                    <input type="text" class="form-control datepicker" placeholder="Transaction Date" value="18-Sept-2017">
                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                </div>
                                            </td>
                                            <td>
                                                <input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="4567">
                                            </td>
                                            <td>
                                                <input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="Claim Variance">
                                            </td>
                                            <td>
                                                <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="-20.00">
                                            </td>
                                            <td class="text-center">
                                                <button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="input-group date smallfield pull-left">
                                                    <input type="text" class="form-control datepicker" placeholder="Transaction Date" value="19-Sept-2017">
                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                </div>
                                            </td>
                                            <td>
                                                <input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="7890">
                                            </td>
                                            <td>
                                                <input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="No Pod">
                                            </td>
                                            <td>
                                                <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="130.00">
                                            </td>
                                            <td class="text-center">
                                                <button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <div class="input-group date smallfield pull-left">
                                                    <input type="text" class="form-control datepicker" placeholder="Transaction Date" value="">
                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                </div>
                                            </td>
                                            <td>
                                                <input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="">
                                            </td>
                                            <td>
                                                <input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="">
                                            </td>
                                            <td>
                                                <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="0.00">
                                            </td>
                                            <td class="text-center">
                                                <button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>
                                            </td>
                                        </tr>
                                    </tbody>
                                    <tfoot>
                                        <tr class="active">
                                            <td colspan="3"><b>TOTAL</b></td>
                                            <td class="text-right borderBottomDouble"><b class="TransTotal">610.00</b></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                            <div class="modal-footer">
                                <Input type="button" value="Cancel" class="btn btn-primary btn-sm" data-dismiss="modal">
                                <a href="#" onclick="addReconTransCons(); return false;" class="btn btn-success btn-sm"><i class="fa fa-plus-circle"></i> Add Reconciling Transaction</a>
                                <Input type="button" value="Submit Error" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#consolidatedError" data-dismiss="modal">
                                <Input type="button" value="Submit" class="btn btn-primary btn-sm" data-dismiss="modal">
                            </div>
                        </div>
                    </div>
                </div>

                <!-- CONSOLIDATED ERROR Modal -->
                <div class="modal fade" id="consolidatedError" tabindex="-1" role="dialog">
                    <div class="modal-dialog modal-sm" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h5 class="modal-title text-danger">Reconciling Error</h5>
                            </div>
                            <div class="modal-body">
                                <div class="alert alert-danger" role="alert">
                                    <div class="media">
                                        <div class="media-left" style="padding-left:2px">
                                            <i class="fa fa-exclamation-triangle fa-3x"></i>
                                        </div>
                                        <div class="media-body">
                                            <b>Error:</b> The total of your reconciling items does not balance to the variance, please correct before continuing.
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <Input type="button" value="Make Correction" class="btn btn-danger btn-sm" data-toggle="modal" data-target="#consolidatedTransactions" data-dismiss="modal">
                            </div>
                        </div>
                    </div>
                </div>

                <!------------------------------ STORE SPECIFIC MODALS ------------------------------>
                <!-- STORE SPECIFIC STATEMENT BALANCE PER STORE Modal -->
                <div class="modal fade" id="storeSpecificGenerate" tabindex="-1" role="dialog">
                    <div class="modal-dialog modal-md" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h5 class="modal-title">Generate Statement Balance per Store</h5>
                            </div>
                            <div class="modal-body">
                                <p>Please enter your statement balance <B>PER STORE</B> for for:</p>
                                <h5 class="text-primary"><b>_Test Creditor</b> as at <b>21-Nov-2017</b></h5>
                                <table class="table-condensed" style="width:100%;">
                                    <tr>
                                        <td><b>Store Name</b></td>
                                        <td class="text-right"><b>EA System Total</b></td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td width="50%">Store #1 <b>(1234)</b></td>
                                        <td class="text-right">
                                            <input type="text" class="form-control input-sm text-right" id="" value="11 411.96" disabled>
                                        </td>
                                        <td class="text-right">
                                            <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" placeholder="0.00" value="11291.96">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Store #2 <b>(1234)</b></td>
                                        <td class="text-right">
                                            <input type="text" class="form-control input-sm text-right" id="" value="26097.99" disabled>
                                        </td>
                                        <td class="text-right">
                                            <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" placeholder="0.00" value="25857.99">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Store #3 <b>(1234)</b></td>
                                        <td class="text-right">
                                            <input type="text" class="form-control input-sm text-right" id="" value="3 776.75" disabled>
                                        </td>
                                        <td class="text-right">
                                            <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" placeholder="0.00" value="3521.69">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Store #4 <b>(1234)</b></td>
                                        <td class="text-right">
                                            <input type="text" class="form-control input-sm text-right" id="" value="9 765.13" disabled>
                                        </td>
                                        <td class="text-right">
                                            <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" placeholder="0.00">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Store #5 <b>(1234)</b></td>
                                        <td class="text-right">
                                            <input type="text" class="form-control input-sm text-right" id="" value="1237.08" disabled>
                                        </td>
                                        <td class="text-right">
                                            <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" placeholder="0.00">
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div class="modal-footer">
                                <Input type="button" value="Submit Store Statement Balances" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#storeSpecificVariance" data-dismiss="modal">
                            </div>
                        </div>
                    </div>
                </div>

                <!-- STORE SPECIFIC VARIANCE Modal -->
                <div class="modal fade" id="storeSpecificVariance" tabindex="-1" role="dialog">
                    <div class="modal-dialog modal-md" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h5 class="modal-title text-warning">Store Specific Remittance Variance</h5>
                            </div>
                            <div class="modal-body">
                                <div class="alert alert-warning" role="alert">
                                    <div class="media">
                                        <div class="media-left" style="padding-left:2px">
                                            <i class="fa fa-exclamation-circle fa-3x"></i>
                                        </div>
                                        <div class="media-body">
                                            <p><b>Please Note:</b> There is a variance of <b>615.06</b> between your remittance and the supplier statement:</p>

                                            <table class="table-condensed" style="width:100%;">
                                                <tr>
                                                    <td><b>Store Name</b></td>
                                                    <td class="text-right"><b>EA System Total</b></td>
                                                    <td class="text-right"><b>Entered Total</b></td>
                                                    <td class="text-right"><b>Variance</b></td>
                                                </tr>
                                                <tr>
                                                    <td>Store #1</td>
                                                    <td class="text-right">11 411.96</td>
                                                    <td class="text-right">11 291.96</td>
                                                    <td class="text-right"><b>120.00</b></td>
                                                </tr>
                                                <tr>
                                                    <td>Store #2</td>
                                                    <td class="text-right">26 097.99</td>
                                                    <td class="text-right">25 857,99</td>
                                                    <td class="text-right"><b>240.00</b></td>
                                                </tr>
                                                <tr>
                                                    <td>Store #3</td>
                                                    <td class="text-right">3 776.75</td>
                                                    <td class="text-right">3 521.69</td>
                                                    <td class="text-right"><b>255.06</b></td>
                                                </tr>
                                            </table>

                                            <h5><b>Do you wisth to continue?</b></h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <Input type="button" value="Back" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#storeSpecificGenerate" data-dismiss="modal">
                                <Input type="button" value="NO" class="btn btn-primary btn-sm" data-dismiss="modal">
                                <Input type="button" value="YES" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#storeSpecificTransactions" data-dismiss="modal">
                            </div>
                        </div>
                    </div>
                </div>

                <!-- STORE SPECIFIC TRANSACTIONS Modal -->
                <div class="modal fade" id="storeSpecificTransactions" tabindex="-1" role="dialog">
                    <div class="modal-dialog modal-md" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h5 class="modal-title">Reconciling Transactions</h5>
                            </div>
                            <div class="modal-body">
                                <p>Please enter the reconciling transactions:</p>

                                <div class="panel-group" id="accordion">
                                    <div class="panel panel-default">
                                        <div class="panel-heading">
                                            <h4 data-toggle="collapse" data-parent="#accordion" href="#collapse1" class="panel-title collapsed">
                                                <span class="right-arrow pull-right"><i class="indicator glyphicon glyphicon-plus"></i></span>
                                                <a href="#">Store #1</a>
                                            </h4>
                                        </div>
                                        <div id="collapse1" class="panel-collapse collapse">
                                            <div class="panel-body">
                                                <table class="table table-striped table-bordered table-condensed">
                                                    <thead>
                                                        <tr>
                                                            <th>Date</th>
                                                            <th>Invoice Number</th>
                                                            <th>Note</th>
                                                            <th class="text-right">Amount</th>
                                                            <th>&nbsp;</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td>
                                                                <div class="input-group date smallfield pull-left">
                                                                    <input type="text" class="form-control datepicker" placeholder="Transaction Date" value="17-Sept-2017">
                                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="1234">
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="Invalid Invoice">
                                                            </td>
                                                            <td>
                                                                <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="120.00">
                                                            </td>
                                                            <td class="text-center">
                                                                <button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <div class="input-group date smallfield pull-left">
                                                                    <input type="text" class="form-control datepicker" placeholder="Transaction Date" value="">
                                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="">
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="">
                                                            </td>
                                                            <td>
                                                                <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="0.00">
                                                            </td>
                                                            <td class="text-center">
                                                                <button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                    <tfoot>
                                                        <tr class="active">
                                                            <td colspan="2">
                                                                <a href="#" class="btn btn-success btn-sm" onclick="addReconTransStore(this); return false;"><i class="fa fa-plus-circle"></i> Add Reconciling Transaction</a>
                                                            </td>
                                                            <td class="text-right"><b>TOTAL</b></td>
                                                            <td class="text-right borderBottomDouble"><b class="TransTotal">120.00</b></td>
                                                            <td>&nbsp;</td>
                                                        </tr>
                                                    </tfoot>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="panel panel-default">
                                        <div class="panel-heading">
                                            <h4 data-toggle="collapse" data-parent="#accordion" href="#collapse2" class="panel-title expand">
                                                <span class="right-arrow pull-right"><i class="indicator glyphicon glyphicon-plus"></i></span>
                                                <a href="#">Store #2</a>
                                            </h4>
                                        </div>
                                        <div id="collapse2" class="panel-collapse collapse">
                                            <div class="panel-body">
                                                <table class="table table-striped table-bordered table-condensed">
                                                    <thead>
                                                        <tr>
                                                            <th>Date</th>
                                                            <th>Invoice Number</th>
                                                            <th>Note</th>
                                                            <th class="text-right">Amount</th>
                                                            <th>&nbsp;</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td>
                                                                <div class="input-group date smallfield pull-left">
                                                                    <input type="text" class="form-control datepicker" placeholder="Transaction Date" value="17-Sept-2017">
                                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="4567">
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="Invalid Invoice">
                                                            </td>
                                                            <td>
                                                                <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="199.98">
                                                            </td>
                                                            <td class="text-center">
                                                                <button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <div class="input-group date smallfield pull-left">
                                                                    <input type="text" class="form-control datepicker" placeholder="Transaction Date" value="">
                                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="">
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="">
                                                            </td>
                                                            <td>
                                                                <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="0.00">
                                                            </td>
                                                            <td class="text-center">
                                                                <button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                    <tfoot>
                                                        <tr class="active">
                                                            <td colspan="2">
                                                                <a href="#" class="btn btn-success btn-sm" onclick="addReconTransStore(this); return false;"><i class="fa fa-plus-circle"></i> Add Reconciling Transaction</a>
                                                            </td>
                                                            <td class="text-right"><b>TOTAL</b></td>
                                                            <td class="text-right borderBottomDouble"><b class="TransTotal">199.98</b></td>
                                                            <td>&nbsp;</td>
                                                        </tr>
                                                    </tfoot>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="panel panel-default">
                                        <div class="panel-heading">
                                            <h4 data-toggle="collapse" data-parent="#accordion" href="#collapse3" class="panel-title expand">
                                                <span class="right-arrow pull-right"><i class="indicator glyphicon glyphicon-plus"></i></span>
                                                <a href="#">Store #3</a>
                                            </h4>
                                        </div>
                                        <div id="collapse3" class="panel-collapse collapse">
                                            <div class="panel-body">
                                                <table class="table table-striped table-bordered table-condensed">
                                                    <thead>
                                                        <tr>
                                                            <th>Date</th>
                                                            <th>Invoice Number</th>
                                                            <th>Note</th>
                                                            <th class="text-right">Amount</th>
                                                            <th>&nbsp;</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td>
                                                                <div class="input-group date smallfield pull-left">
                                                                    <input type="text" class="form-control datepicker" placeholder="Transaction Date" value="17-Sept-2017">
                                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="7890">
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="Invalid Invoice">
                                                            </td>
                                                            <td>
                                                                <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="255.06">
                                                            </td>
                                                            <td class="text-center">
                                                                <button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <div class="input-group date smallfield pull-left">
                                                                    <input type="text" class="form-control datepicker" placeholder="Transaction Date" value="">
                                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="">
                                                            </td>
                                                            <td>
                                                                <input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="">
                                                            </td>
                                                            <td>
                                                                <input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="0.00">
                                                            </td>
                                                            <td class="text-center">
                                                                <button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                    <tfoot>
                                                        <tr class="active">
                                                            <td colspan="2">
                                                                <a href="#" class="btn btn-success btn-sm" onclick="addReconTransStore(this); return false;"><i class="fa fa-plus-circle"></i> Add Reconciling Transaction</a>
                                                            </td>
                                                            <td class="text-right"><b>TOTAL</b></td>
                                                            <td class="text-right borderBottomDouble"><b class="TransTotal">255.06</b></td>
                                                            <td>&nbsp;</td>
                                                        </tr>
                                                    </tfoot>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <Input type="button" value="Cancel" class="btn btn-primary btn-sm" data-dismiss="modal">
                                <Input type="button" value="Submit Error" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#storeSpecificError" data-dismiss="modal">
                                <Input type="button" value="Submit" class="btn btn-primary btn-sm" data-dismiss="modal">
                            </div>
                        </div>
                    </div>
                </div>

                <!-- STORE SPECIFIC ERROR Modal -->
                <div class="modal fade" id="storeSpecificError" tabindex="-1" role="dialog">
                    <div class="modal-dialog modal-sm" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                <h5 class="modal-title text-danger">Reconciling Error</h5>
                            </div>
                            <div class="modal-body">
                                <div class="alert alert-danger" role="alert">
                                    <div class="media">
                                        <div class="media-left" style="padding-left:2px">
                                            <i class="fa fa-exclamation-triangle fa-3x"></i>
                                        </div>
                                        <div class="media-body">
                                            <b>Error:</b> The total of your reconciling items does not balance to the variance, please correct before continuing.
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <Input type="button" value="Make Correction" class="btn btn-danger btn-sm" data-toggle="modal" data-target="#storeSpecificTransactions" data-dismiss="modal">
                            </div>
                        </div>
                    </div>
                </div>

            </div>
            <!-- .panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>
<!-- /.row -->
@section Scripts

    <!-- The Script below prevents the body from scrolling when the modal is scrollable -->
<script>
    var scrollPos = 0;

    $('.modal')
        .on('show.bs.modal', function () {
            scrollPos = $('body').scrollTop();
            $('body').css({
                overflow: 'hidden',
                position: 'fixed',
                width: '100%',
                top: -scrollPos
            });
        })
        .on('hide.bs.modal', function () {
            $('body').css({
                overflow: '',
                position: '',
                top: ''
            }).scrollTop(scrollPos);
        });
</script>




    <!-- Page-Level Demo Scripts - Notifications - Use for reference -->
    <script>
        // tooltip demo
        $('.tooltip-demo').tooltip({
            selector: "[data-toggle=tooltip]",
            container: "body"
        });

        // popover demo
        $("[data-toggle=popover]").popover();

        /* NEW MODALS & FUNCTIONS */

        function doRebateNew() {
            $("#frmRebate").submit();
        }

        function remittanceOptions() {

            $(".statementOption").removeClass("active");

            $("#remittanceOptions").modal("show");
            $("#reconcilePayment").hide();
        }

        function doViewRemittance() {
            $("#IFrame").attr("src", "MasterTransactions_View_Remittance.asp?RebateID=" + frmRebate.selRemittance.value);
            $("#IFrameModal").modal("show");
        }

        function reconcilePayment() {
            $("#reconcilePayment").show();
        }
       
        function addReconTransCons() {
            var _table = $("#reconTransAction");

            var _addThis = '<tr>';
            _addThis = _addThis + '<td>';
            _addThis = _addThis + '<div class="input-group date smallfield pull-left">';
            _addThis = _addThis + '<input type="text" class="form-control datepicker" placeholder="Transaction Date" value="">';
            _addThis = _addThis + '<span class="input-group-addon"><i class="fa fa-calendar"></i></span>';
            _addThis = _addThis + '</div>';
            _addThis = _addThis + '</td>';
            _addThis = _addThis + '<td>';
            _addThis = _addThis + '<input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="">';
            _addThis = _addThis + '</td>';
            _addThis = _addThis + '<td>';
            _addThis = _addThis + '<input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="">';
            _addThis = _addThis + '</td>';
            _addThis = _addThis + '<td>';
            _addThis = _addThis + '<input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="0.00">';
            _addThis = _addThis + '</td>';
            _addThis = _addThis + '<td class="text-center">';
            _addThis = _addThis + '<button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>';
            _addThis = _addThis + '</td>';
            _addThis = _addThis + '</tr>';

            _table.append(_addThis);

            //Reinitialize datepicker for newly added row
            $('.input-group.date').datepicker({
                autoclose: true,
                todayHighlight: true,
                format: "d-M-yyyy"
            });
            //add row to table
            console.warn("add new row");
        }

        function addReconTransStore(El) {
            var _table = $(El).closest("table");

            //console.warn(_table.html())
            var _addThis = '<tr>';
            _addThis = _addThis + '<td>';
            _addThis = _addThis + '<div class="input-group date smallfield pull-left">';
            _addThis = _addThis + '<input type="text" class="form-control datepicker" placeholder="Transaction Date" value="">';
            _addThis = _addThis + '<span class="input-group-addon"><i class="fa fa-calendar"></i></span>';
            _addThis = _addThis + '</div>';
            _addThis = _addThis + '</td>';
            _addThis = _addThis + '<td>';
            _addThis = _addThis + '<input type="text" class="form-control input-sm" id="" placeholder="Invoice Number" value="">';
            _addThis = _addThis + '</td>';
            _addThis = _addThis + '<td>';
            _addThis = _addThis + '<input type="text" class="form-control input-sm" id="" placeholder="Enter Note" value="">';
            _addThis = _addThis + '</td>';
            _addThis = _addThis + '<td>';
            _addThis = _addThis + '<input type="number" step="0.01" class="form-control input-sm text-right" name="consAmount" id="" onchange="consAmountTotal(this, event); return false;" placeholder="0.00" value="0.00">';
            _addThis = _addThis + '</td>';
            _addThis = _addThis + '<td class="text-center">';
            _addThis = _addThis + '<button class="btn btn-danger btn-xs" onclick="delTrans(this, event); return false;"><i class="fa fa-minus-circle" aria-hidden="true"></i></button>';
            _addThis = _addThis + '</td>';
            _addThis = _addThis + '</tr>';
       
            _table.append(_addThis);

            //Reinitialize datepicker for newly added row
            $('.input-group.date').datepicker({
                autoclose: true,
                todayHighlight: true,
                format: "d-M-yyyy"
            });
            //add row to table
            console.warn("add new row");
        }

        function delTrans(El, e) {
            //Remove row from table
            //console.warn("remove");

            var _thisEl = El.closest("table");

            var _removeThis = $(El).closest("tr").remove();

            setTotal(_thisEl);
        }

        function consAmountTotal(El, e) {
            var _inputVal = $(El).val();
            var _isNum = $.isNumeric(_inputVal);

            var finalnumber = 0.00;

            var _inputs = $('[name="consAmount"]');

            var _totalVal = $(".TransTotal");

            var _removeThis = $(El).closest("table");

            setTotal(_removeThis);
        }

        function setTotal(El) {
            var _totalVal = $(El).find(".TransTotal");
            //var _totalVal2 = $(El).closest(".TransTotal");
            
            //console.warn(_totalVal.html())
            //console.warn(_totalVal2.html())
            var total = 0.00;

            $(El).find('[name="consAmount"]').each(function () {
                //var _inputVal = $(this).val();
                var _inputVal = parseFloat($(this).val()).toFixed(2) || 0;


                /*if (isNaN(_inputVal) === true) {
                    _inputVal = 0.00;
                    console.warn("not a number")
                }*/

                total += parseFloat(_inputVal);
            });

            _totalVal.html(parseFloat(total).toFixed(2));
        }
    </script>

<!-- The Script below is for the accordion collapse -->
<script>
    $(function () {
        $('#accordion').on('show.bs.collapse', function (e) {
            if (e.target.className.indexOf("panel-collapse") >= 0) {
                $(e.target).closest('.panel-default').addClass('panel-primary');
            }
            $('.bs.collapse').collapse('hide');
        }).on('hide.bs.collapse', function (e) {
            if (e.target.className.indexOf("panel-collapse") >= 0) {
                $(e.target).closest('.panel-default').removeClass('panel-primary');
            }
        })

        function toggleChevron(e) {
            $(e.target)
                .prev('.panel-heading')
                .find("i.indicator")
                .toggleClass('glyphicon-minus glyphicon-plus');
        }
        $('#accordion').on('hidden.bs.collapse', function () {
            toggleChevron;
        });
        $('#accordion').on('shown.bs.collapse', function () {
            toggleChevron;
        });
    });
</script>
End Section