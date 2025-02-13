﻿/*
 * @(#)License.cs        5.1.1    2022-11-20
 *
 * MathParser.org-mXparser DUAL LICENSE AGREEMENT as of date 2022-05-22
 * The most up-to-date license is available at the below link:
 * - https://mathparser.org/mxparser-license
 *
 * AUTHOR: Copyright 2010 - 2022 Mariusz Gromada - All rights reserved
 * PUBLISHER: INFIMA - https://payhip.com/infima
 *
 * SOFTWARE means source code and/or binary form and/or documentation.
 * PRODUCT: MathParser.org-mXparser SOFTWARE
 * LICENSE: DUAL LICENSE AGREEMENT
 *
 * BY INSTALLING, COPYING, OR OTHERWISE USING THE PRODUCT, YOU AGREE TO BE
 * BOUND BY ALL OF THE TERMS AND CONDITIONS OF THE DUAL LICENSE AGREEMENT.
 *
 * AUTHOR & PUBLISHER provide the PRODUCT under the DUAL LICENSE AGREEMENT
 * model designed to meet the needs of both non-commercial use as well as
 * commercial use.
 *
 * NON-COMMERCIAL USE means any use or activity where a fee is not charged
 * and the purpose is not the sale of a good or service, and the use or
 * activity is not intended to produce a profit. NON-COMMERCIAL USE examples:
 *
 * 1. Free Open-Source Software ("FOSS").
 * 2. Non-commercial use in research, scholarly and education.
 *
 * COMMERCIAL USE means any use or activity where a fee is charged or the
 * purpose is the sale of a good or service, or the use or activity is
 * intended to produce a profit. COMMERCIAL USE examples:
 *
 * 1. OEMs (Original Equipment Manufacturers).
 * 2. ISVs (Independent Software Vendors).
 * 3. VARs (Value Added Resellers).
 * 4. Other distributors that combine and distribute commercially licensed
 *    software.
 *
 * IN CASE YOU WANT TO USE THE PRODUCT COMMERCIALLY, YOU MUST PURCHASE THE
 * APPROPRIATE LICENSE FROM "INFIMA" ONLINE STORE, STORE ADDRESS:
 *
 * 1. https://mathparser.org/order-commercial-license
 * 2. https://payhip.com/infima
 *
 * NON-COMMERCIAL LICENSE
 *
 * Redistribution and use of the PRODUCT in source and/or binary forms,
 * with or without modification, are permitted provided that the following
 * conditions are met:
 *
 * 1. Redistributions of source code must retain unmodified content of the
 *    entire MathParser.org-mXparser DUAL LICENSE AGREEMENT, including
 *    definition of NON-COMMERCIAL USE, definition of COMMERCIAL USE,
 *    NON-COMMERCIAL LICENSE conditions, COMMERCIAL LICENSE conditions, and
 *    the following DISCLAIMER.
 * 2. Redistributions in binary form must reproduce the entire content of
 *    MathParser.org-mXparser DUAL LICENSE AGREEMENT in the documentation
 *    and/or other materials provided with the distribution, including
 *    definition of NON-COMMERCIAL USE, definition of COMMERCIAL USE,
 *    NON-COMMERCIAL LICENSE conditions, COMMERCIAL LICENSE conditions, and
 *    the following DISCLAIMER.
 * 3. Any form of redistribution requires confirmation and signature of
 *    the NON-COMMERCIAL USE by successfully calling the method:
 *       License.iConfirmNonCommercialUse(...)
 *    The method call takes place only internally for logging purposes and
 *    there is no connection with other external services and no data is
 *    sent or collected. The lack of a method call (or its successful call)
 *    does not affect the operation of the PRODUCT in any way. Please see
 *    the API documentation.
 *
 * COMMERCIAL LICENSE
 *
 *  1. Before purchasing a commercial license, AUTHOR & PUBLISHER allow you
 *     to download, install and use up to three copies of the PRODUCT to
 *     perform integration tests, confirm the quality of the PRODUCT and
 *     its suitability. The testing period should be limited to fourteen
 *     days. Tests should be performed under the conditions of test
 *     environments. The purpose of the tests must not be to generate profit.
 *  2. Provided that you purchased a license from "INFIMA" online store
 *     (store address: https://mathparser.org/order-commercial-license or
 *     https://payhip.com/infima), and you comply with all below terms and
 *     conditions, and you have acknowledged and understood the following
 *     DISCLAIMER, AUTHOR & PUBLISHER grant you a nonexclusive license
 *     including the following rights:
 *  3. The license has been granted only to you, i.e., the person or entity
 *     that made the purchase, who is identified and confirmed by the data
 *     provided during the purchase.
 *  4. In case you purchased a license in the "ONE-TIME PURCHASE" model,
 *     the license has been granted only for the PRODUCT version specified
 *     in the purchase. The upgrade policy gives you additional rights and
 *     is described in the dedicated section below.
 *  5. In case you purchased a license in the "SUBSCRIPTION" model, you can
 *     install and use any version of the PRODUCT, but only during the
 *     subscription validity period.
 *  6. In case you purchased a "SINGLE LICENSE" you can install and use the
 *     PRODUCT from one workstation.
 *  7. Additional copies of the PRODUCT can be installed and used from more
 *     than one workstation; however, this number is limited to the number
 *     of workstations purchased as per order.
 *  8. In case you purchased a "SITE LICENSE ", the PRODUCT can be installed
 *     and used from all workstations located at your premises.
 *  9. You may incorporate the unmodified PRODUCT into your own products
 *     and software.
 * 10. If you purchased a license with the "SOURCE CODE" option, you may
 *     modify the PRODUCT's source code and incorporate the modified source
 *     code into your own products and/or software.
 * 11. Provided that the license validity period has not expired, you may
 *     distribute your product and/or software with the incorporated
 *     PRODUCT royalty-free.
 * 12. You may make copies of the PRODUCT for backup and archival purposes.
 * 13. Any form of redistribution requires confirmation and signature of
 *     the COMMERCIAL USE by successfully calling the method:
 *        License.iConfirmCommercialUse(...)
 *     The method call takes place only internally for logging purposes and
 *     there is no connection with other external services and no data is
 *     sent or collected. The lack of a method call (or its successful call)
 *     does not affect the operation of the PRODUCT in any way. Please see
 *     the API documentation.
 * 14. AUTHOR & PUBLISHER reserve all rights not expressly granted to you
 *     in this agreement.
 *
 * ADDITIONAL CLARIFICATION ON WORKSTATION
 *
 * A workstation is a device, a remote device, or a virtual device, used by
 * you, your employees, or other entities to whom you have commissioned the
 * tasks. For example, the number of workstations may refer to the number
 * of software developers, engineers, architects, scientists, and other
 * professionals who use the PRODUCT on your behalf. The number of
 * workstations is not the number of copies of your end-product that you
 * distribute to your end-users.
 *
 * By purchasing the COMMERCIAL LICENSE, you only pay for the number of
 * workstations, while the number of copies of your final product
 * (delivered to your end-users) is not limited.
 *
 * UPGRADE POLICY
 *
 * The PRODUCT is versioned according to the following convention:
 *
 *    [MAJOR].[MINOR].[PATCH]
 *
 * 1. COMMERCIAL LICENSE holders can install and use the updated version
 *    for bug fixes free of charge, i.e. if you have purchased a license
 *    for the [MAJOR].[MINOR] version (e.g.: 5.0), you can freely install
 *    all the various releases specified in the [PATCH] version (e.g.: 5.0.2).
 *    The license terms remain unchanged after the update.
 * 2. COMMERCIAL LICENSE holders for [MAJOR].[MINOR] version (e.g.: 5.0)
 *    can install and use the updated version [MAJOR].[MINOR + 1] free of
 *    charge, i.e., plus one release in the [MINOR] range (e.g.: 5.1). The
 *    license terms remain unchanged after the update.
 * 3. COMMERCIAL LICENSE holders who wish to upgrade their version, but are
 *    not eligible for the free upgrade, can claim a discount when
 *    purchasing the upgrade. For this purpose, please contact us via e-mail.
 *
 * DISCLAIMER
 *
 * THIS PRODUCT IS PROVIDED BY AUTHOR & PUBLISHER "AS IS" AND ANY EXPRESS
 * OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL AUTHOR OR PUBLISHER OR CONTRIBUTORS BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS PRODUCT, EVEN IF ADVISED OF
 * THE POSSIBILITY OF SUCH DAMAGE.
 *
 * THE VIEWS AND CONCLUSIONS CONTAINED IN THE PRODUCT AND DOCUMENTATION ARE
 * THOSE OF THE AUTHORS AND SHOULD NOT BE INTERPRETED AS REPRESENTING
 * OFFICIAL POLICIES, EITHER EXPRESSED OR IMPLIED, OF AUTHOR OR PUBLISHER.
 *
 * CONTACT
 *
 * - e-mail: info@mathparser.org
 * - website: https://mathparser.org
 * - source code: https://github.com/mariuszgromada/MathParser.org-mXparser
 * - online store: https://mathparser.org/order-commercial-license
 * - online store: https://payhip.com/infima
 */
using System;

namespace org.mariuszgromada.math.mxparser {
	/**
	 * A class that provides commercial and non-commercial use mode registration.
	 * The execution of methods in this class does not affect the operation
	 * of the MathParser.org-mXparser software, but is required by the terms of the
	 * License.geTermsOfAgreement().
	 *
	 * @author         <b>Mariusz Gromada</b><br>
	 *                 <a href="https://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
	 *                 <a href="https://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser on GitHub</a><br>
	 *                 <a href="https://payhip.com/INFIMA" target="_blank">INFIMA place to purchase a commercial MathParser.org-mXparser software license</a><br>
	 *                 <a href="mailto:info@mathparser.org">info@mathparser.org</a><br>
	 *                 <a href="https://scalarmath.org/" target="_blank">ScalarMath.org - a powerful math engine and math scripting language</a><br>
	 *                 <a href="https://play.google.com/store/apps/details?id=org.mathparser.scalar.lite" target="_blank">Scalar Lite</a><br>
	 *                 <a href="https://play.google.com/store/apps/details?id=org.mathparser.scalar.pro" target="_blank">Scalar Pro</a><br>
	 *                 <a href="https://mathspace.pl" target="_blank">MathSpace.pl</a><br>
	 *
	 * @version        5.1.1
	 *
	 * @see #iConfirmNonCommercialUse(String)
	 * @see #iConfirmCommercialUse(String)
	 * @see #geTermsOfAgreement()
	 * @see #checkIfUseTypeConfirmed()
	 * @see #getUseTypeConfirmationMessage()
	 */
	public class License {
		private static UseType typeOfUse = UseType.Null;
		private static String signature = null;
		private static int numberOfConfirmationAttempts = 0;
		private static String message = StringInvariant.EMPTY;
		private static String errorMessage = StringInvariant.EMPTY;
		private const String ERROR_NOT_CONFIRMED = "The type of use has not been confirmed. You can test the software, but its distribution does not comply with the License.geTermsOfAgreement().";
		private enum UseType {
			Null
            ,NonCommercial
            ,Commercial
		}
		private enum MessageType {
			ERROR
			,WARNING
		}
		internal static int getUseType() {
			if (typeOfUse == UseType.Null) return 0;
			if (typeOfUse == UseType.NonCommercial) return 1;
			if (typeOfUse == UseType.Commercial) return 2;
			return 3;
		}
		private static void setErrorMessage(MessageType type, String errorMessage) {
			License.errorMessage = type + ": " + errorMessage;
			mXparser.consolePrintln(License.errorMessage);
		}
		private static void setMessageConfirmedCommercial() {
			message = "You \"" + signature + "\" have confirmed the commercial use according to the License.geTermsOfAgreement(). Thank you.";
		}
		private static void setMessageConfirmedNonCommercial() {
			message = "You \"" + signature + "\" have confirmed the non-commercial use according to the License.geTermsOfAgreement(). Thank you.";
		}
		private static bool checkIfProperSignature(String providedSignature) {
			if (providedSignature == null) {
				setErrorMessage(MessageType.ERROR, "The signature cannot be null.");
				return false;
			}
			if (providedSignature.Trim().Length < 5) {
				setErrorMessage(MessageType.ERROR, "The signature cannot be shorter than 5 characters.");
				return false;
			}
			return true;
		}
		private static bool checkIfNoPreviousConfirmationAttempts() {
			if (numberOfConfirmationAttempts == 0)
				return true;
			setErrorMessage(MessageType.ERROR, "Only one attempt of use type confirmation can be made. If you want to modify the confirmed use type, you should identify the previous call and change it.");
			return false;
		}
		private static bool checkLackOfPreviousConfirmation() {
			if (typeOfUse == UseType.Null || signature == null)
				return true;
			setErrorMessage(MessageType.WARNING, "You cannot change a previously signed confirmation. " + message + " If you want to modify the confirmed use type, you should identify the previous call and change it.");
			return false;
		}
		/**
		 * By successfully calling this method, you confirm and sign that you use MathParser.org-mXparser
		 * commercially according to the License.geTermsOfAgreement(). The confirmation can only be
		 * called once. The method call takes place only internally for logging purposes and there is no
		 * connection with other external services and no data is sent or collected. The lack of a method
		 * call (or its successful call) does not affect the operation of the PRODUCT in any way.
		 *
		 * @param mySignature    Your first and last name or your e-mail address or your company name.
		 *                       At least 5 non-blank characters.
		 * @return   Logs commercial use and returns true if this was the first attempt to register
		 *           a use type and the signature met the conditions specified for it. Otherwise, returns
		 *           false and does not log use type.
		 *
		 * @see #iConfirmNonCommercialUse(String)
		 * @see #getUseTypeConfirmationMessage()
		 * @see #checkIfUseTypeConfirmed()
		 * @see #geTermsOfAgreement()
		 */
		public static bool iConfirmCommercialUse(String mySignature) {
			if (!checkLackOfPreviousConfirmation())
				return false;
			if (!checkIfNoPreviousConfirmationAttempts())
				return false;
			numberOfConfirmationAttempts++;
			if (!checkIfProperSignature(mySignature))
				return false;
			signature = mySignature.Trim();
			typeOfUse = UseType.Commercial;
			setMessageConfirmedCommercial();
			return true;
		}
		/**
		 * By successfully calling this method, you confirm and sign that you use MathParser.org-mXparser
		 * non-commercially according to the License.geTermsOfAgreement(). The confirmation can only be
		 * called once. The method call takes place only internally for logging purposes and there is no
		 * connection with other external services and no data is sent or collected. The lack of a method
		 * call (or its successful call) does not affect the operation of the PRODUCT in any way.
		 *
		 * @param mySignature    Your first and last name or your e-mail address or your company name.
		 *                       At least 5 non-blank characters.
		 * @return   Logs non-commercial use and returns true if this was the first attempt to register
		 *           a use type and the signature met the conditions specified for it. Otherwise, returns
		 *           false and does not log use type.
		 *
		 * @see #iConfirmNonCommercialUse(String)
		 * @see #getUseTypeConfirmationMessage()
		 * @see #checkIfUseTypeConfirmed()
		 * @see #geTermsOfAgreement()
		 */
		public static bool iConfirmNonCommercialUse(String mySignature) {
			if (!checkLackOfPreviousConfirmation())
				return false;
			if (!checkIfNoPreviousConfirmationAttempts())
				return false;
			numberOfConfirmationAttempts++;
			if (!checkIfProperSignature(mySignature))
				return false;
			signature = mySignature.Trim();
			typeOfUse = UseType.NonCommercial;
			setMessageConfirmedNonCommercial();
			return true;
		}
		/**
		 * Verifies whether the use type has been successfully confirmed and signed.
		 *
		 * @return   True in case commercial or non-commercial user type has been confirmed and signed.
		 *           Otherwise, returns false.
		 */
		public static bool checkIfUseTypeConfirmed() {
			if (numberOfConfirmationAttempts == 0) {
				setErrorMessage(MessageType.WARNING, ERROR_NOT_CONFIRMED);
				return false;
			}
			if (typeOfUse == UseType.Null || signature == null) {
				setErrorMessage(MessageType.ERROR, ERROR_NOT_CONFIRMED);
				return false;
			}
			if (typeOfUse == UseType.NonCommercial)
				setMessageConfirmedNonCommercial();
			if (typeOfUse == UseType.Commercial)
				setMessageConfirmedCommercial();
			return true;
		}
		/**
		 * Verifies whether the use type has been successfully confirmed and signed.
		 *
		 * @return   Confirmation message in case commercial or non-commercial user type has been
		 *           confirmed and signed. Otherwise, returns error / warning message.
		 */
		public static String getUseTypeConfirmationMessage() {
			if (!checkIfUseTypeConfirmed())
				return errorMessage;
			return message;
		}
		/**
		 * Return the terms of MathParser.org-mXparser DUAL LICENSE AGREEMENT.
		 *
		 * @return   The terms of MathParser.org-mXparser DUAL LICENSE AGREEMENT as string.
		 */
		public static String geTermsOfAgreement() {
			return MATHPARSERORG_MXPARSER_DUAL_LICENSE_AGREEMENT;
		}
		/**
		 * Prints to the console the terms of MathParser.org-mXparser DUAL LICENSE AGREEMENT
		 */
		public static void consolePrintLicense() {
			mXparser.consolePrint("\n\n");
			mXparser.consolePrint(MATHPARSERORG_MXPARSER_DUAL_LICENSE_AGREEMENT);
			mXparser.consolePrintln();
		}
		/**
		 * The terms of MathParser.org-mXparser DUAL LICENSE AGREEMENT
		 */
		public static readonly String MATHPARSERORG_MXPARSER_DUAL_LICENSE_AGREEMENT =
			"mXparser - version " + mXparser.VERSION + "\n"
			+ "MathParser.org-mXparser DUAL LICENSE AGREEMENT as of date 2022-05-22\n"
			+ "The most up-to-date license is available at the below link:\n"
			+ "- https://mathparser.org/mxparser-license\n"
			+ "\n"
			+ "AUTHOR: Copyright 2010 - 2022 Mariusz Gromada - All rights reserved\n"
			+ "PUBLISHER: INFIMA - https://payhip.com/infima\n"
			+ "\n"
			+ "SOFTWARE means source code and/or binary form and/or documentation.\n"
			+ "PRODUCT: MathParser.org-mXparser SOFTWARE\n"
			+ "LICENSE: DUAL LICENSE AGREEMENT\n"
			+ "\n"
			+ "BY INSTALLING, COPYING, OR OTHERWISE USING THE PRODUCT, YOU AGREE TO BE\n"
			+ "BOUND BY ALL OF THE TERMS AND CONDITIONS OF THE DUAL LICENSE AGREEMENT.\n"
			+ "\n"
			+ "AUTHOR & PUBLISHER provide the PRODUCT under the DUAL LICENSE AGREEMENT\n"
			+ "model designed to meet the needs of both non-commercial use as well as\n"
			+ "commercial use.\n"
			+ "\n"
			+ "NON-COMMERCIAL USE means any use or activity where a fee is not charged\n"
			+ "and the purpose is not the sale of a good or service, and the use or\n"
			+ "activity is not intended to produce a profit. NON-COMMERCIAL USE examples:\n"
			+ "\n"
			+ "1. Free Open-Source Software (\"FOSS\").\n"
			+ "2. Non-commercial use in research, scholarly and education.\n"
			+ "\n"
			+ "COMMERCIAL USE means any use or activity where a fee is charged or the\n"
			+ "purpose is the sale of a good or service, or the use or activity is\n"
			+ "intended to produce a profit. COMMERCIAL USE examples:\n"
			+ "\n"
			+ "1. OEMs (Original Equipment Manufacturers).\n"
			+ "2. ISVs (Independent Software Vendors).\n"
			+ "3. VARs (Value Added Resellers).\n"
			+ "4. Other distributors that combine and distribute commercially licensed\n"
			+ "   software.\n"
			+ "\n"
			+ "IN CASE YOU WANT TO USE THE PRODUCT COMMERCIALLY, YOU MUST PURCHASE THE\n"
			+ "APPROPRIATE LICENSE FROM \"INFIMA\" ONLINE STORE, STORE ADDRESS:\n"
			+ "\n"
			+ "1. https://mathparser.org/order-commercial-license\n"
			+ "2. https://payhip.com/infima\n"
			+ "\n"
			+ "NON-COMMERCIAL LICENSE\n"
			+ "\n"
			+ "Redistribution and use of the PRODUCT in source and/or binary forms,\n"
			+ "with or without modification, are permitted provided that the following\n"
			+ "conditions are met:\n"
			+ "\n"
			+ "1. Redistributions of source code must retain unmodified content of the\n"
			+ "   entire MathParser.org-mXparser DUAL LICENSE AGREEMENT, including\n"
			+ "   definition of NON-COMMERCIAL USE, definition of COMMERCIAL USE,\n"
			+ "   NON-COMMERCIAL LICENSE conditions, COMMERCIAL LICENSE conditions, and\n"
			+ "   the following DISCLAIMER.\n"
			+ "2. Redistributions in binary form must reproduce the entire content of\n"
			+ "   MathParser.org-mXparser DUAL LICENSE AGREEMENT in the documentation\n"
			+ "   and/or other materials provided with the distribution, including\n"
			+ "   definition of NON-COMMERCIAL USE, definition of COMMERCIAL USE,\n"
			+ "   NON-COMMERCIAL LICENSE conditions, COMMERCIAL LICENSE conditions, and\n"
			+ "   the following DISCLAIMER.\n"
			+ "3. Any form of redistribution requires confirmation and signature of\n"
			+ "   the NON-COMMERCIAL USE by successfully calling the method:\n"
			+ "      License.iConfirmNonCommercialUse(...)\n"
			+ "   The method call takes place only internally for logging purposes and\n"
			+ "   there is no connection with other external services and no data is\n"
			+ "   sent or collected. The lack of a method call (or its successful call)\n"
			+ "   does not affect the operation of the PRODUCT in any way. Please see\n"
			+ "   the API documentation.\n"
			+ "\n"
			+ "COMMERCIAL LICENSE\n"
			+ "\n"
			+ " 1. Before purchasing a commercial license, AUTHOR & PUBLISHER allow you\n"
			+ "    to download, install and use up to three copies of the PRODUCT to\n"
			+ "    perform integration tests, confirm the quality of the PRODUCT and\n"
			+ "    its suitability. The testing period should be limited to fourteen\n"
			+ "    days. Tests should be performed under the conditions of test\n"
			+ "    environments. The purpose of the tests must not be to generate profit.\n"
			+ " 2. Provided that you purchased a license from \"INFIMA\" online store\n"
			+ "    (store address: https://mathparser.org/order-commercial-license or\n"
			+ "    https://payhip.com/infima), and you comply with all below terms and\n"
			+ "    conditions, and you have acknowledged and understood the following\n"
			+ "    DISCLAIMER, AUTHOR & PUBLISHER grant you a nonexclusive license\n"
			+ "    including the following rights:\n"
			+ " 3. The license has been granted only to you, i.e., the person or entity\n"
			+ "    that made the purchase, who is identified and confirmed by the data\n"
			+ "    provided during the purchase.\n"
			+ " 4. In case you purchased a license in the \"ONE-TIME PURCHASE\" model,\n"
			+ "    the license has been granted only for the PRODUCT version specified\n"
			+ "    in the purchase. The upgrade policy gives you additional rights and\n"
			+ "    is described in the dedicated section below.\n"
			+ " 5. In case you purchased a license in the \"SUBSCRIPTION\" model, you can\n"
			+ "    install and use any version of the PRODUCT, but only during the\n"
			+ "    subscription validity period.\n"
			+ " 6. In case you purchased a \"SINGLE LICENSE\" you can install and use the\n"
			+ "    PRODUCT from one workstation.\n"
			+ " 7. Additional copies of the PRODUCT can be installed and used from more\n"
			+ "    than one workstation; however, this number is limited to the number\n"
			+ "    of workstations purchased as per order.\n"
			+ " 8. In case you purchased a \"SITE LICENSE \", the PRODUCT can be installed\n"
			+ "    and used from all workstations located at your premises.\n"
			+ " 9. You may incorporate the unmodified PRODUCT into your own products\n"
			+ "    and software.\n"
			+ "10. If you purchased a license with the \"SOURCE CODE\" option, you may\n"
			+ "    modify the PRODUCT's source code and incorporate the modified source\n"
			+ "    code into your own products and/or software.\n"
			+ "11. Provided that the license validity period has not expired, you may\n"
			+ "    distribute your product and/or software with the incorporated\n"
			+ "    PRODUCT royalty-free.\n"
			+ "12. You may make copies of the PRODUCT for backup and archival purposes.\n"
			+ "13. Any form of redistribution requires confirmation and signature of\n"
			+ "    the COMMERCIAL USE by successfully calling the method:\n"
			+ "       License.iConfirmCommercialUse(...)\n"
			+ "    The method call takes place only internally for logging purposes and\n"
			+ "    there is no connection with other external services and no data is\n"
			+ "    sent or collected. The lack of a method call (or its successful call)\n"
			+ "    does not affect the operation of the PRODUCT in any way. Please see\n"
			+ "    the API documentation.\n"
			+ "14. AUTHOR & PUBLISHER reserve all rights not expressly granted to you\n"
			+ "    in this agreement.\n"
			+ "\n"
			+ "ADDITIONAL CLARIFICATION ON WORKSTATION\n"
			+ "\n"
			+ "A workstation is a device, a remote device, or a virtual device, used by\n"
			+ "you, your employees, or other entities to whom you have commissioned the\n"
			+ "tasks. For example, the number of workstations may refer to the number\n"
			+ "of software developers, engineers, architects, scientists, and other\n"
			+ "professionals who use the PRODUCT on your behalf. The number of\n"
			+ "workstations is not the number of copies of your end-product that you\n"
			+ "distribute to your end-users.\n"
			+ "\n"
			+ "By purchasing the COMMERCIAL LICENSE, you only pay for the number of\n"
			+ "workstations, while the number of copies of your final product\n"
			+ "(delivered to your end-users) is not limited.\n"
			+ "\n"
			+ "UPGRADE POLICY\n"
			+ "\n"
			+ "The PRODUCT is versioned according to the following convention:\n"
			+ "\n"
			+ "   [MAJOR].[MINOR].[PATCH]\n"
			+ "\n"
			+ "1. COMMERCIAL LICENSE holders can install and use the updated version\n"
			+ "   for bug fixes free of charge, i.e. if you have purchased a license\n"
			+ "   for the [MAJOR].[MINOR] version (e.g.: 5.0), you can freely install\n"
			+ "   all the various releases specified in the [PATCH] version (e.g.: 5.0.2).\n"
			+ "   The license terms remain unchanged after the update.\n"
			+ "2. COMMERCIAL LICENSE holders for [MAJOR].[MINOR] version (e.g.: 5.0)\n"
			+ "   can install and use the updated version [MAJOR].[MINOR + 1] free of\n"
			+ "   charge, i.e., plus one release in the [MINOR] range (e.g.: 5.1). The\n"
			+ "   license terms remain unchanged after the update.\n"
			+ "3. COMMERCIAL LICENSE holders who wish to upgrade their version, but are\n"
			+ "   not eligible for the free upgrade, can claim a discount when\n"
			+ "   purchasing the upgrade. For this purpose, please contact us via e-mail.\n"
			+ "\n"
			+ "DISCLAIMER\n"
			+ "\n"
			+ "THIS PRODUCT IS PROVIDED BY AUTHOR & PUBLISHER \"AS IS\" AND ANY EXPRESS\n"
			+ "OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED\n"
			+ "WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE\n"
			+ "DISCLAIMED. IN NO EVENT SHALL AUTHOR OR PUBLISHER OR CONTRIBUTORS BE\n"
			+ "LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR\n"
			+ "CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF\n"
			+ "SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS\n"
			+ "INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN\n"
			+ "CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)\n"
			+ "ARISING IN ANY WAY OUT OF THE USE OF THIS PRODUCT, EVEN IF ADVISED OF\n"
			+ "THE POSSIBILITY OF SUCH DAMAGE.\n"
			+ "\n"
			+ "THE VIEWS AND CONCLUSIONS CONTAINED IN THE PRODUCT AND DOCUMENTATION ARE\n"
			+ "THOSE OF THE AUTHORS AND SHOULD NOT BE INTERPRETED AS REPRESENTING\n"
			+ "OFFICIAL POLICIES, EITHER EXPRESSED OR IMPLIED, OF AUTHOR OR PUBLISHER.\n"
			+ "\n"
			+ "CONTACT\n"
			+ "\n"
			+ "- e-mail: info@mathparser.org\n"
			+ "- website: https://mathparser.org\n"
			+ "- source code: https://github.com/mariuszgromada/MathParser.org-mXparser\n"
			+ "- online store: https://mathparser.org/order-commercial-license\n"
			+ "- online store: https://payhip.com/infima\n"
			;
	}
}