using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    class SinglyLinkedListNode {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData) {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter) {
        while (node != null) {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null) {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the findMergeNode function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        int len1 = 0;
    SinglyLinkedListNode temp1 = head1;
    while (temp1 != null) {
        len1++;
        temp1 = temp1.next;
    }
    
    int len2 = 0;
    SinglyLinkedListNode temp2 = head2;
    while (temp2 != null) {
        len2++;
        temp2 = temp2.next;
    }
    
   
    SinglyLinkedListNode ptr1 = head1;
    SinglyLinkedListNode ptr2 = head2;
    
    if (len1 > len2) {
        int diff = len1 - len2;
        for (int i = 0; i < diff; i++) {
            ptr1 = ptr1.next;
        }
    } else if (len2 > len1) {
        int diff = len2 - len1;
        for (int i = 0; i < diff; i++) {
            ptr2 = ptr2.next;
        }
    }


    while (ptr1 != ptr2) {
        ptr1 = ptr1.next;
        ptr2 = ptr2.next;
    }
    
 
    if (ptr1 == null) {
        return -1;  
    }
    
    return ptr1.data;        


    }

    static v
